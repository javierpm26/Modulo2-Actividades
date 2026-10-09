USE exploracion_submarina;
SHOW TABLES;

-- CREAR USUARIOS
CREATE USER 'investigador'@'localhost'
IDENTIFIED BY 'Investigador123!';

CREATE USER 'observador'@'localhost'
IDENTIFIED BY 'Observador123!';

-- CONSULTAR USUARIOS
SELECT User, Host
FROM mysql.user;

-- CONCEDER PERMISOS CON GRANT
GRANT SELECT
ON exploracion_submarina.*
TO 'observador'@'localhost';

GRANT SELECT, INSERT, UPDATE
ON exploracion_submarina.*
TO 'investigador'@'localhost';

GRANT DELETE
ON exploracion_submarina.*
TO 'investigador'@'localhost';

-- RETIRAR PERMISOS CON REVOKE
REVOKE UPDATE
ON exploracion_submarina.*
FROM 'investigador'@'localhost';

-- CONSULTAR PERMISOS
SHOW GRANTS FOR 'observador'@'localhost';
SHOW GRANTS FOR 'investigador'@'localhost';

-- ELIMINAR USUARIOS
DROP USER 'observador'@'localhost';
DROP USER 'investigador'@'localhost';

-- TRANSACCIÓN COMMIT
START TRANSACTION;

UPDATE expedicion
SET duracion_horas = 20
WHERE id_expedicion = 1;

SELECT id_expedicion, nombre, duracion_horas
FROM expedicion
WHERE id_expedicion = 1;

COMMIT;

-- TRANSACCIÓN ROLLBACK
START TRANSACTION;

UPDATE expedicion
SET duracion_horas = 25
WHERE id_expedicion = 1;

SELECT id_expedicion, nombre, duracion_horas
FROM expedicion
WHERE id_expedicion = 1;

ROLLBACK;

-- TRANSACCIÓN SAVEPOINT
START TRANSACTION;

UPDATE expedicion
SET duracion_horas = 18
WHERE id_expedicion = 1;

SAVEPOINT punto1;

UPDATE expedicion
SET duracion_horas = 15
WHERE id_expedicion = 2;

SELECT id_expedicion, nombre, duracion_horas
FROM expedicion
WHERE id_expedicion IN (1, 2);

ROLLBACK TO SAVEPOINT punto1;

UPDATE expedicion
SET duracion_horas = 12
WHERE id_expedicion = 2;

COMMIT;

-- TRANSACCION CON VARIAS OPERACIONES SAVEPOINT
START TRANSACTION;

INSERT INTO investigador
(nombre, especialidad)
VALUES
('Mario Torres', 'Robótica submarina');

SAVEPOINT antes_de_muestra;

INSERT INTO muestra
(id_expedicion, tipo, profundidad_m, masa_kg)
VALUES
(1, 'Mineral', 3500, 1.50);

SELECT *
FROM muestra
WHERE tipo = 'Mineral';

ROLLBACK TO SAVEPOINT antes_de_muestra;

SELECT *
FROM investigador
WHERE nombre = 'Mario Torres';

COMMIT;

-- TRANSACCION ROLLBACK COMPLETO
START TRANSACTION;

INSERT INTO investigador
(nombre, especialidad)
VALUES
('Prueba Rollback', 'Oceanografía');

UPDATE expedicion
SET duracion_horas = 30
WHERE id_expedicion = 3;

ROLLBACK;

SELECT *
FROM investigador
WHERE nombre = 'Prueba Rollback';