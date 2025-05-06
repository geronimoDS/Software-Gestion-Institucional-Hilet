-- TABLAS ---------------------------------------------------------------------------------------------------

CREATE TABLE Usuarios
(
	ID_Login INT PRIMARY KEY IDENTITY,
	Usuario VARCHAR(30) NOT NULL,
	Pass VARCHAR(30) NOT NULL,
	Rol VARCHAR(20) NOT NULL,
	Baja BIT NOT NULL
);

CREATE TABLE Alumnos
(
	ID_Matricula INT PRIMARY KEY IDENTITY,
	Apellido VARCHAR(30) NOT NULL,
	Nombre VARCHAR(30) NOT NULL,
	DNI INT NOT NULL,
	FechaNacimiento DATE NOT NULL,
	Mail VARCHAR(50),
	Telefono1 VARCHAR(20),
	Telefono2 VARCHAR(20),
	Domicilio VARCHAR(50),
	FechaInscripcion DATE,
	ID_Login INT,
	Baja BIT NOT NULL
	FOREIGN KEY (ID_Login) REFERENCES Usuarios(ID_Login)
);

CREATE TABLE Personal
(
	ID_Personal INT PRIMARY KEY IDENTITY,
	Apellido VARCHAR(30) NOT NULL,
	Nombre VARCHAR(30) NOT NULL,
	DNI INT NOT NULL,
	FechaNacimiento DATE NOT NULL,
	Mail VARCHAR(50),
	Telefono1 VARCHAR(20),
	Telefono2 VARCHAR(20),
	Domicilio VARCHAR(50),
	Cargo VARCHAR(30) NOT NULL,
	FechaInicio DATE,
	ID_Login INT,
	Baja BIT NOT NULL
	FOREIGN KEY (ID_Login) REFERENCES Usuarios(ID_Login)
);

CREATE TABLE Carreras
(
	ID_Carrera INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(50) NOT NULL,
	NResolucion INT NOT NULL,
	Descripcion VARCHAR(250),
	Baja BIT NOT NULL
);

CREATE TABLE Materias
(
	ID_Materia INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(50) NOT NULL,
	Descripcion VARCHAR(250),
	Baja BIT NOT NULL
);


CREATE TABLE MateriasXCarrera
(
	ID_MateriasXCarrera INT PRIMARY KEY IDENTITY,
	ID_Carrera INT,
	ID_Materia INT,
	AnioCursada INT,
	FOREIGN KEY (ID_Carrera) REFERENCES Carreras(ID_Carrera),
	FOREIGN KEY (ID_Materia) REFERENCES Materias(ID_Materia)
);

CREATE TABLE AlumnosXCarrera
(
	ID_AlumnosXCarrera INT PRIMARY KEY IDENTITY,
	ID_Matricula INT,
	ID_Carrera INT,
	AnioCursada INT,
	FOREIGN KEY (ID_Matricula) REFERENCES Alumnos(ID_Matricula),
	FOREIGN KEY (ID_Carrera) REFERENCES Carreras(ID_Carrera)
);

CREATE TABLE MateriasXAlumno
(
	ID_MateriasXAlumno INT PRIMARY KEY IDENTITY,
	ID_Materia INT,
	ID_Matricula INT,
	FOREIGN KEY (ID_Materia) REFERENCES Materias(ID_Materia),
	FOREIGN KEY (ID_Matricula) REFERENCES Alumnos(ID_Matricula)
);

CREATE TABLE Examen
(
	ID_Examen INT PRIMARY KEY IDENTITY,
	Fecha DATE NOT NULL,
	TipoExamen VARCHAR(30),
	AnioExamen INT,
	ID_Profesor INT,
	ID_MateriasXCarrera INT,
	Baja BIT NOT NULL,
	FOREIGN KEY (ID_Profesor) REFERENCES Personal(ID_Personal),
	FOREIGN KEY (ID_MateriasXCarrera) REFERENCES MateriasXCarrera(ID_MateriasXCarrera)
);

CREATE TABLE NotasXAlumno
(
	ID_NotasXAlumno INT PRIMARY KEY IDENTITY,
	Nota FLOAT,
	ID_Alumno INT,
	ID_Examen INT,
	FOREIGN KEY (ID_Alumno) REFERENCES Alumnos(ID_Matricula),
	FOREIGN KEY (ID_Examen) REFERENCES Examen(ID_Examen)
);

CREATE TABLE ProfesoresXMaterias
(
	ID_ProfesoresXMaterias INT PRIMARY KEY IDENTITY,
	ID_Profesor INT,
	ID_Materia INT,
	FOREIGN KEY (ID_Profesor) REFERENCES Personal(ID_Personal),
	FOREIGN KEY (ID_Materia) REFERENCES Materias(ID_Materia)
);



-- PROCEDIMIENTOS---------------------------------------------------------------------------------------

-- Usuarios ---------------------------------------------
CREATE PROCEDURE sp_PrimerArranque -- Para el primer arranque del programa
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM Usuarios)
	BEGIN
		DBCC CHECKIDENT ('Usuarios', RESEED, 1);
		INSERT INTO Usuarios VALUES ('admin', 'admin', 'administrador', 0);
	END
END;


CREATE PROCEDURE sp_CrearUsuario
	@Usuario VARCHAR(30),
	@Pass VARCHAR(30),
	@Rol VARCHAR(20),
	@UBaja BIT
AS
BEGIN
	INSERT INTO Usuarios
    VALUES (@Usuario, @Pass, @Rol, @UBaja);
END;



--Alumnos -----------------------------------------------
----------------AGREGAR ALUMNO Y CARRERA---------
CREATE PROCEDURE sp_AgregarAlumnoYcarrera
	@Apellido VARCHAR(30),
	@Nombre VARCHAR(30),
	@DNI INT,
	@FechaNacimiento DATE,
	@Mail VARCHAR(50),
	@Telefono1 VARCHAR(20),
	@Telefono2 VARCHAR(20),
	@Domicilio VARCHAR(50),
	@FechaInscripcion DATE,
	@Baja BIT,
	@ID_Carrera INT,    -- Nuevo parámetro para la carrera seleccionada
	@AnioCursada INT    -- Año de la cursada
AS
BEGIN
	-- Crear un usuario con el DNI del alumno
	EXEC sp_CrearUsuario @Usuario = @DNI, @Pass = @DNI, @Rol = 'alumno', @UBaja = @Baja;
	
	-- Conseguir el ID del usuario creado
    DECLARE @ID_Login INT;
	SELECT @ID_Login = IDENT_CURRENT('Usuarios');

	-- Insertar el nuevo alumno
    INSERT INTO Alumnos (Apellido, Nombre, DNI, FechaNacimiento, Mail, Telefono1, Telefono2, Domicilio, FechaInscripcion, ID_Login, Baja)
    VALUES (@Apellido, @Nombre, @DNI, @FechaNacimiento, @Mail, @Telefono1, @Telefono2, @Domicilio, @FechaInscripcion, @ID_Login, @Baja);
    
    -- Obtener el ID_Matricula del nuevo alumno
    DECLARE @ID_Matricula INT;
    SELECT @ID_Matricula = SCOPE_IDENTITY(); -- Esto obtiene el último ID generado en la sesión actual

    -- Insertar en la tabla AlumnosXCarrera
    INSERT INTO AlumnosXCarrera (ID_Matricula, ID_Carrera, AnioCursada)
    VALUES (@ID_Matricula, @ID_Carrera, @AnioCursada);

	-- Agregar las materias segun su carrera y año de cursada
	EXEC sp_AgregarMateriasXAlumno @Alumno = @ID_Matricula, @Cursada = @AnioCursada;
    
END;
----------------------

CREATE PROCEDURE sp_DarBajaAlumno
    @DNI INT
AS
BEGIN
	-- Actualizar el campo Baja a 1 para el alumno con el DNI proporcionado
    UPDATE Alumnos
    SET Baja = 1
    WHERE DNI = @DNI;

	-- Conseguir el ID_Login del alumno por su DNI
	DECLARE @ID_Login INT;
	SELECT @ID_Login = ID_Login FROM Alumnos WHERE DNI = @DNI;

	-- Actualizar el campo Baja a 1 para el alumno con el ID conseguido
	UPDATE Usuarios
	SET Baja = 1
	WHERE ID_Login = @ID_Login
END;



CREATE PROCEDURE sp_DarAltaAlumno
    @DNI INT
AS
BEGIN
	-- Actualizar el campo Baja a 0 para el alumno con el DNI proporcionado
    UPDATE Alumnos
    SET Baja = 0
    WHERE DNI = @DNI;

	-- Conseguir el ID_Login del alumno por su DNI
	DECLARE @ID_Login INT;
	SELECT @ID_Login = ID_Login FROM Alumnos WHERE DNI = @DNI;

	-- Actualizar el campo Baja a 0 para el alumno con el ID conseguido
	UPDATE Usuarios
	SET Baja = 0
	WHERE ID_Login = @ID_Login
END;

--Actualizar alumno, su año de carrera y materias
CREATE PROCEDURE sp_ActualizarAlumnoYCarrera
    @DNI INT, -- Usamos el DNI como identificador único
    @Apellido VARCHAR(30),
    @Nombre VARCHAR(30),
    @FechaNacimiento DATE,
    @Mail VARCHAR(50),
    @Telefono1 VARCHAR(20),
    @Telefono2 VARCHAR(20),
    @Domicilio VARCHAR(50),
    @FechaInscripcion DATE,
    @ID_Matricula INT, -- Identificador para la tabla alumnosxCarrera
    @anioCursada INT, -- Nuevo valor para anioCursada
    @Id_Carrera INT -- Nuevo valor para Id_Carrera
AS
BEGIN
    -- Iniciar la actualización en Alumnos
    UPDATE Alumnos
    SET
        Apellido = @Apellido,
        Nombre = @Nombre,
        FechaNacimiento = @FechaNacimiento,
        Mail = @Mail,
        Telefono1 = @Telefono1,
        Telefono2 = @Telefono2,
        Domicilio = @Domicilio,
        FechaInscripcion = @FechaInscripcion
    WHERE DNI = @DNI; -- Se actualiza usando el DNI como filtro

    -- Actualizar alumnosxCarrera
    UPDATE AlumnosXCarrera
    SET
        AnioCursada = @AnioCursada,
        ID_Carrera = @ID_Carrera
    WHERE ID_Matricula = @ID_Matricula; -- Se actualiza usando id_Matricula como filtro

	-- Agregar las materias segun su carrera y año de cursada
	EXEC sp_AgregarMateriasXAlumno @Alumno = @ID_Matricula, @Cursada = @anioCursada;
END;


--Personal -------------------------------------------------------------------------------------
CREATE PROCEDURE sp_AgregarPersonal
	@Apellido VARCHAR(30),
	@Nombre VARCHAR(30),
	@DNI INT,
	@FechaNacimiento DATE,
	@Mail VARCHAR(50),
	@Telefono1 VARCHAR(20),
	@Telefono2 VARCHAR(20),
	@Domicilio VARCHAR(50),
	@Cargo VARCHAR(30),
	@FechaInicio DATE,
	@Baja BIT
AS
BEGIN
	-- Crear un usuario con el DNI del alumno
	EXEC sp_CrearUsuario @Usuario = @DNI, @Pass = @DNI, @Rol = @Cargo, @UBaja = @Baja;
	
	-- Conseguir el ID del usuario creado
    DECLARE @ID_Login INT;
	SELECT @ID_Login = IDENT_CURRENT('Usuarios');

	-- Cargar el nuevo alumno con su ID de login creado
    INSERT INTO Personal
    VALUES (@Apellido, @Nombre, @DNI, @FechaNacimiento, @Mail, @Telefono1, @Telefono2, @Domicilio, @Cargo, @FechaInicio, @ID_Login, @Baja);
END;


CREATE PROCEDURE sp_DarBajaPersonal
    @DNI INT
AS
BEGIN
	-- Actualizar el campo Baja a 1 para el alumno con el DNI proporcionado
    UPDATE Personal
    SET Baja = 1
    WHERE DNI = @DNI;

	-- Conseguir el ID_Login del alumno por su DNI
	DECLARE @ID_Login INT;
	SELECT @ID_Login = ID_Login FROM Personal WHERE DNI = @DNI;

	-- Actualizar el campo Baja a 1 para el alumno con el ID conseguido
	UPDATE Usuarios
	SET Baja = 1
	WHERE ID_Login = @ID_Login
END;



CREATE PROCEDURE sp_DarAltaPersonal
    @DNI INT
AS
BEGIN
	-- Actualizar el campo Baja a 0 para el alumno con el DNI proporcionado
    UPDATE Personal
    SET Baja = 0
    WHERE DNI = @DNI;

	-- Conseguir el ID_Login del alumno por su DNI
	DECLARE @ID_Login INT;
	SELECT @ID_Login = ID_Login FROM Alumnos WHERE DNI = @DNI;

	-- Actualizar el campo Baja a 0 para el alumno con el ID conseguido
	UPDATE Personal
	SET Baja = 0
	WHERE ID_Login = @ID_Login
END;



CREATE PROCEDURE sp_ActualizarPersonal
    @DNI INT, -- Usamos el DNI como identificador único
--Actualiza todo menos el DNI! OJOOO
    @Apellido VARCHAR(30),
    @Nombre VARCHAR(30),
    @FechaNacimiento DATE,
    @Mail VARCHAR(50),
    @Telefono1 VARCHAR(20),
    @Telefono2 VARCHAR(20),
    @Domicilio VARCHAR(50),
	@Cargo VARCHAR(30),
    @FechaInicio DATE
AS
BEGIN
    -- Iniciar la actualización
    UPDATE Personal
    SET
        Apellido = @Apellido,
        Nombre = @Nombre,
        FechaNacimiento = @FechaNacimiento,
        Mail = @Mail,
        Telefono1 = @Telefono1,
        Telefono2 = @Telefono2,
        Domicilio = @Domicilio,
		Cargo = @Cargo,
        FechaInicio = @FechaInicio
    WHERE DNI = @DNI; -- Se actualiza usando el DNI como filtro
END;



-- Materias ------------------------------------------------------------------
CREATE PROCEDURE sp_MateriaNueva
	@Nombre VARCHAR(50),
	@Descripcion VARCHAR(250),
	@ID_Profesor INT
AS
BEGIN
	INSERT INTO Materias VALUES(@Nombre, @Descripcion, 0);

	DECLARE @ID_Materia INT;
	SELECT @ID_Materia = IDENT_CURRENT('Materias');

	IF @ID_Profesor != 0
		INSERT INTO ProfesoresXMaterias VALUES (@ID_Profesor, @ID_Materia);
END;


CREATE PROCEDURE sp_MateriaEditar
	@ID_Materia INT,
	@Nombre VARCHAR(50),
	@Descripcion VARCHAR(250),
	@ID_Profesor INT
AS
BEGIN
	UPDATE Materias
	SET
		Nombre = @Nombre,
		Descripcion = @Descripcion
	WHERE
		ID_Materia = @ID_Materia;

	DECLARE @TieneProf INT;

	-- Ver si ya estaba cargada en la tabla pivot
	IF @ID_Profesor != 0
	IF EXISTS (SELECT 1 FROM ProfesoresXMaterias WHERE ID_Materia = @ID_Materia)
		UPDATE ProfesoresXMaterias
		SET
			ID_Profesor = @ID_Profesor
		WHERE ID_Materia = @ID_Materia;
	ELSE
		INSERT INTO ProfesoresXMaterias VALUES (@ID_Profesor, @ID_Materia);
END;


CREATE PROCEDURE sp_AgregarMateriasXAlumno
	@Alumno INT,
	@Cursada INT
	AS
	BEGIN
		INSERT INTO MateriasXAlumno(ID_Materia, ID_Matricula)
		SELECT MXC.ID_Materia, AXC.ID_Matricula FROM MateriasXCarrera AS MXC, AlumnosXCarrera AS AXC
		WHERE MXC.ID_Carrera = AXC.ID_Carrera AND MXC.AnioCursada = @Cursada AND AXC.ID_Matricula = @Alumno
	END;

-- Usuarios --------------------------------------------------------------------------------------------------------------
-----------MOFICAR USUARIO--------
create procedure sp_ActualizarUsuario
	@ID_Login int,
	@Usuario VARCHAR(30) ,
	@Pass VARCHAR(30) ,
	@Rol VARCHAR(20) 
as
begin
	update Usuarios 
	set Usuario = @Usuario,
		Pass = @Pass,
		Rol = @Rol
		where ID_Login = @ID_Login;
end;
----------------------------------

-------------------------------------
-------------BUSCA EL O LOS ALUMNO/S-----------
CREATE PROCEDURE sp_SearchAlumn
	@Apellido VARCHAR(30)
AS
BEGIN
		SELECT a.ID_Matricula, a.Apellido, a.Nombre FROM Alumnos as a
		WHERE @Apellido = a.Apellido;
END;
--------BUSCA TODOS LOS DATOS DEL ALUMNO-------
CREATE PROCEDURE sp_ALLDateAlumn
	@Matricula int
AS
BEGIN
		SELECT a.ID_Matricula, a.Apellido, a.Nombre, a.DNI, a.FechaNacimiento, a.Mail, a.Telefono1, a.Telefono2, a.Domicilio, a.FechaInscripcion, a.Baja FROM Alumnos as a
		WHERE @Matricula = a.ID_Matricula
END;
---------BUSCA LAS NOTAS DEL ALUMNO-----------
CREATE PROCEDURE sp_SearchNotas
	@Matricula int
AS
BEGIN
SELECT	
		c.nombre as Carrera,
		m.Nombre as Materia,
		e.TipoExamen as Examen,
		nt.Nota 
			FROM NotasXAlumno as NT
				JOIN Examen e on nt.ID_Examen = e.ID_Examen
				JOIN Alumnos a on nt.ID_Alumno = a.ID_Matricula
				JOIN MateriasXCarrera ma on e.ID_MateriasXCarrera = MA.ID_MateriasXCarrera 
				join Materias m on ma.ID_Materia = m.ID_Materia
				join Carreras c on ma.ID_Carrera = c.ID_Carrera
					WHERE a.ID_Matricula = @Matricula;
END;
-------------BUSCA LAS NOTAS DE LA CARRERA-----------

CREATE PROCEDURE sp_SearchALLNOTAS
	 @ID_Examen int,
	 @ID_Materia int,
	 @ID_Carrera int,
	 @ID_anio int
AS
BEGIN
		SELECT
		M.Nombre AS Materia,
		E.TipoExamen AS Examen,
		NA.Nota,
		A.ID_Matricula AS Matricula,
		A.Nombre,
		A.Apellido
				from NotasXAlumno as NA
				JOIN Examen E on Na.ID_Examen = E.ID_Examen
				JOIN MateriasXCarrera MC on E.ID_MateriasXCarrera = MC.ID_MateriasXCarrera
				JOIN Materias M on MC.ID_Materia = M.ID_Materia
				JOIN Carreras C ON MC.ID_Carrera = C.ID_Carrera
				JOIN Alumnos A ON NA.ID_Alumno = A.ID_Matricula
				WHERE E.ID_Examen = @ID_Examen AND M.ID_Materia = @ID_Materia AND C.ID_Carrera = @ID_Carrera AND e.AnioExamen = @ID_anio
END;

-------BUSCAR LA MATRICULA CON EL INICIO DE SESION---------
CREATE PROCEDURE sp_SearchID_Login
	@ID_LOGIN int
AS
BEGIN
	
	SELECT 
		A.ID_Matricula 
			FROM 
				Alumnos A
					JOIN Usuarios U on A.ID_Login = U.ID_Login
						WHERE A.ID_Login = @ID_LOGIN;
END;
----------------BUSCAR LAS MATERIAS DE LA CARRERA---------------
CREATE PROCEDURE sp_BuscarMaterias
	@ID_Carrera int
AS
BEGIN
	SELECT M.Nombre FROM MATERIAS AS M
	JOIN MateriasXCarrera MA ON M.ID_Materia = MA.ID_Materia
	JOIN Carreras C ON MA.ID_Carrera = C.ID_Carrera
	WHERE C.ID_Carrera = @ID_Carrera
END;
---------------BUSCAR LOS EXAMENES DE LA MATERIA X CARRERA---------
CREATE PROCEDURE sp_BuscarExamen
	@ID_Carrera INT,
	@ID_Materia INT,
	@ID_Anio INT
AS
BEGIN
	SELECT E.TipoExamen FROM Examen as E
	JOIN MateriasXCarrera MA ON E.ID_MateriasXCarrera = MA.ID_MateriasXCarrera
	JOIN Materias M ON MA.ID_Materia = M.ID_Materia
	JOIN Carreras C ON MA.ID_Carrera = C.ID_Carrera
	WHERE  MA.ID_Carrera = @ID_Carrera AND  MA.ID_Materia = @ID_Materia AND E.AnioExamen = @ID_Anio
END;
---------------BUSCAR LOS EXAMENES DE LA MATERIA X CARRERA---------
CREATE PROCEDURE sp_SearchMatXCarr
	@ID_Materia int,
	@ID_Carrera int
AS
BEGIN
	SELECT MA.ID_MateriasXCarrera FROM MateriasXCarrera MA 
	JOIN Materias M ON MA.ID_Materia = M.ID_Materia
	JOIN Carreras C ON MA.ID_Carrera = C.ID_Carrera
	WHERE MA.ID_Carrera = @ID_Carrera AND MA.ID_Materia = @ID_Materia
END;
---------------CREAR Y CARGAR LOS EXAMENES---------
CREATE PROCEDURE sp_CreateExam
	@Fecha DATE,
	@TipoExamen VARCHAR(30),
	@AnioExamen INT,
	@ID_Profesor int,
	@ID_MateriasXCarrera int,
	@Baja bit
AS
BEGIN
	INSERT INTO Examen VALUES
	(@Fecha,@TipoExamen,@AnioExamen,@ID_Profesor,@ID_MateriasXCarrera,@Baja)
END;
---------------GUARDAR LAS NOTAS---------
CREATE PROCEDURE sp_AgregarNota
	@Nota int,
	@ID_Alumno int,
	@ID_Examen int
AS
BEGIN
	INSERT INTO NotasXAlumno VALUES
	(@Nota,@ID_Alumno,@ID_Examen)
END;
---------------BUSCA EL AÑO DE CARRERA X MATERIA---------
CREATE PROCEDURE sp_SearchYear
	@ID_Carrera int,
	@ID_Materia int
AS
BEGIN
	SELECT AnioCursada FROM MateriasXCarrera
	WHERE ID_Carrera = @ID_Carrera AND ID_Materia = @ID_Materia
END;

---------------ACTUALIZA MI PERFIL--------------------
 create procedure sp_ActualizarMiPerfil
	@ID_Login int,
	@Pass VARCHAR(30)	 
as
begin
	update Usuarios 
	set Pass = @Pass	
		where ID_Login = @ID_Login;
end;
-------------------
