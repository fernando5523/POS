USE RetailPOS;
GO

CREATE VIEW eUsers
AS
SELECT
	Users.Id
	, Activo = Users.Active
	, Nombre = Users.Name
	, Contraseña = Users.Password
FROM
	Users;
GO

CREATE VIEW eContainers
AS
SELECT
	Containers.Id
	, Activo = Containers.Active
	, [Contenedor padre] = ISNULL(FatherContainer.Description, '')
	, Codigo = Containers.Code
	, Nombre = Containers.Name
	, Descripcion = Containers.Description
	, Nivel = Containers.Level
	, Formulario = ISNULL(Containers.Form, '')
	, Orden = Containers.Sort
	, [Es vista] = Containers.IsView
	, [Ultima modificacion] = Users.Name
FROM
	Containers
	INNER JOIN Users ON Containers.IdUser = Users.Id
	LEFT JOIN Containers AS FatherContainer ON Containers.IdContainer = FatherContainer.Id;
GO

CREATE VIEW eCodings
AS
SELECT
	Codings.Id
	, Activo = Codings.Active
	, Contenedor = Containers.Description
	, Texto = Codings.Text
	, [Número] = Codings.Number
	, [Logitud número] = Codings.NumberLength
	, [Ultima modificacion] = Users.Name
FROM
	Codings
	INNER JOIN Users ON Codings.IdUser = Users.Id
	INNER JOIN Containers ON Codings.IdContainer = Containers.Id;
GO