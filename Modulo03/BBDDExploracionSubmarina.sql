-- CREACION BASE DATOS Y TABLAS

CREATE DATABASE exploracion_submarina;
USE exploracion_submarina;

CREATE TABLE zona (
	id_zona INT AUTO_INCREMENT,
	nombre VARCHAR(100) NOT NULL,
	ubicacion VARCHAR(100) NOT NULL,
	profundidad_maxima INT NOT NULL,
    
	PRIMARY KEY (id_zona)
);

CREATE TABLE sumergible (
	id_sumergible INT AUTO_INCREMENT,
	nombre VARCHAR(100) NOT NULL,
	modelo VARCHAR(100) NOT NULL,
	autonomia_horas INT NOT NULL,
    
	PRIMARY KEY (id_sumergible)
);

CREATE TABLE investigador (
	id_investigador INT AUTO_INCREMENT,
	nombre VARCHAR(100) NOT NULL,
	especialidad VARCHAR(100) NOT NULL,
    
	PRIMARY KEY (id_investigador)
);

CREATE TABLE expedicion (
	id_expedicion INT AUTO_INCREMENT,
	nombre VARCHAR(150) NOT NULL,
	fecha_salida DATE NOT NULL,
	duracion_horas INT NOT NULL,
	id_zona INT NOT NULL,
	id_sumergible INT NOT NULL,
    
	PRIMARY KEY (id_expedicion),
    
	FOREIGN KEY (id_zona)
		REFERENCES zona(id_zona),
	FOREIGN KEY (id_sumergible)
		REFERENCES sumergible(id_sumergible)
);

CREATE TABLE participacion (
	id_expedicion INT,
	id_investigador INT,
    
	PRIMARY KEY (id_expedicion, id_investigador),
    
	FOREIGN KEY (id_expedicion)
		REFERENCES expedicion(id_expedicion),
	FOREIGN KEY (id_investigador)
		REFERENCES investigador(id_investigador)
);

CREATE TABLE muestra (
	id_muestra INT AUTO_INCREMENT,
	id_expedicion INT NOT NULL,
	tipo VARCHAR(100) NOT NULL,
	profundidad_m INT NOT NULL,
	masa_kg DECIMAL(6,2) NOT NULL,
    
	PRIMARY KEY (id_muestra),
    
	FOREIGN KEY (id_expedicion)
		REFERENCES expedicion(id_expedicion)
);

-- INSERCIÓN DATOS
INSERT INTO zona (nombre, ubicacion, profundidad_maxima) VALUES
('Abismo de Calipso', 'Atlántico Norte', 4000),
('Arrecife Boreal', 'Mar de Noruega', 800),
('Cañón Azul', 'Mediterráneo', 2200),
('Bosque de Coral', 'Pacífico Sur', 300),
('Llanura Somera', 'Mar del Norte', 150);

INSERT INTO sumergible (nombre, modelo, autonomia_horas) VALUES
('Nautilus-X', 'Explorer 3000', 18),
('Triton II', 'Deep Scout', 12),
('Leviathan', 'Abyss Pro', 20),
('Mako', 'Mini Explorer', 8);

INSERT INTO investigador (nombre, especialidad) VALUES
('Alba Ruiz', 'Biología marina'),
('Diego Martín', 'Geología'),
('Nora Vidal', 'Microbiología'),
('Mateo Sanz', 'Robótica submarina'),
('Sara León', 'Oceanografía');

INSERT INTO expedicion (nombre, fecha_salida, duracion_horas, id_zona, id_sumergible) VALUES
('Primera inmersión Calipso', '2026-09-10', 14, 1, 1),
('Cartografía Boreal', '2026-09-12', 8, 2, 2),
('Cañón Azul Norte', '2026-09-15', 11, 3, 3),
('Fondo Calipso', '2026-09-18', 16, 1, 1),
('Coral Nocturno', '2026-09-20', 6, 4, 2),
('Silencio Abisal', '2026-09-25', 9, 3, 3);

INSERT INTO participacion (id_expedicion, id_investigador) VALUES
(1, 1),
(1, 2),
(2, 2),
(2, 3),
(3, 1),
(3, 4),
(4, 2),
(4, 3),
(4, 4),
(5, 1),
(6, 3);

INSERT INTO muestra (id_expedicion, tipo, profundidad_m, masa_kg) VALUES
(1, 'Sedimento', 3500, 2.40),
(1, 'Organismo', 3600, 1.70),
(1, 'Sedimento', 3420, 0.90),
(2, 'Coral', 120, 1.20),
(2, 'Sedimento', 150, 0.80),
(2, 'Organismo', 95, 2.00),
(3, 'Sedimento', 870, 3.30),
(3, 'Organismo', 910, 2.50),
(4, 'Sedimento', 3900, 1.10),
(4, 'Organismo', 3760, 0.60),
(4, 'Microorganismo', 3850, 1.30),
(5, 'Coral', 80, 0.70),
(5, 'Organismo', 120, 0.50);

-- CONSULTAS FUNCIONES AGREGACIÓN
-- 1. Mostrar cuántas muestras se han recogido en total.
SELECT COUNT(*) AS num_muestras FROM muestra;

-- 2. Mostrar la masa total de las muestras recogidas.
SELECT SUM(masa_kg) AS total_masa_muestras FROM muestra;

-- 3. Mostrar la profundidad media de todas las muestras.
SELECT AVG(profundidad_m) AS profundidad_media_muestra FROM muestra;

-- 4. Mostrar la muestra recogida a mayor profundidad.
SELECT MAX(profundidad_m) AS profundidad_max_muestra FROM muestra;

-- 5. Mostrar la muestra recogida a menor profundidad.
SELECT MIN(profundidad_m) AS profundidad_min_muestra FROM muestra;

-- 6. Mostrar cuántas muestras se han recogido en cada expedición.
SELECT E.nombre, COUNT(*) AS muestras_recogidas_por_exp
FROM muestra M JOIN expedicion E
ON M.id_expedicion = E.id_expedicion
GROUP BY E.id_expedicion, E.nombre;

-- 7. Mostrar la masa total de muestras recogida en cada expedición.
SELECT E.nombre, SUM(M.masa_kg) AS total_masa_muestras_exp
FROM muestra M JOIN expedicion E
ON M.id_expedicion = E.id_expedicion
GROUP BY E.id_expedicion, E.nombre;

-- 8. Mostrar la profundidad media de las muestras de cada expedición.
SELECT E.nombre, AVG(M.profundidad_m) AS profundidad_media_muestra_exp
FROM muestra M JOIN expedicion E
ON M.id_expedicion = E.id_expedicion
GROUP BY E.id_expedicion, E.nombre;

-- 9. Mostrar la profundidad máxima y mínima registrada en cada expedición.
SELECT E.nombre, MAX(M.profundidad_m) AS profundidad_max_muestra_exp, MIN(M.profundidad_m) AS profundidad_min_muestra_exp
FROM muestra M JOIN expedicion E
ON M.id_expedicion = E.id_expedicion
GROUP BY E.id_expedicion, E.nombre;

-- CONSULTAS HAVING
-- 10. Mostrar únicamente las expediciones que hayan recogido más de 2 muestras.
SELECT E.nombre, COUNT(*) AS exp_muestras_recogidas_mayor2
FROM muestra M JOIN expedicion E
ON M.id_expedicion = E.id_expedicion
GROUP BY E.id_expedicion, E.nombre
HAVING COUNT(*) > 2;

-- 11. Mostrar únicamente las expediciones cuya masa total de muestras sea superior a 4 kg.
SELECT E.nombre, SUM(masa_kg) AS total_masa_muestras_mayor4kg
FROM muestra M JOIN expedicion E
ON M.id_expedicion = E.id_expedicion
GROUP BY E.id_expedicion, E.nombre
HAVING SUM(masa_kg) > 4;

-- 12. Mostrar únicamente las expediciones cuya profundidad media sea superior a 1000 m.
SELECT E.nombre, AVG(profundidad_m) AS profundidad_media_superior1000m
FROM muestra M JOIN expedicion E
ON M.id_expedicion = E.id_expedicion
GROUP BY E.id_expedicion, E.nombre
HAVING AVG(profundidad_m) > 1000;

-- CONSULTAS INNER JOIN
-- 13. Mostrar el nombre de cada expedición junto con el nombre de la zona en la que se realizó.
SELECT E.nombre AS expedicion, Z.nombre AS zona_realizada
FROM expedicion E JOIN zona Z
ON E.id_zona = Z.id_zona;

-- 14. Mostrar el nombre de cada expedición y el nombre del sumergible utilizado.
SELECT E.nombre AS expedicion, S.nombre AS sumergible_utilizado
FROM expedicion E JOIN sumergible S
ON E.id_sumergible = S.id_sumergible;

-- 15. Mostrar el nombre de la expedición, su zona y su sumergible.
SELECT E.nombre AS expedicion, Z.nombre AS zona_realizada, S.nombre AS sumergible_utilizado
FROM expedicion E 
JOIN zona Z ON E.id_zona = Z.id_zona
JOIN sumergible S ON E.id_sumergible = S.id_sumergible;

-- 16. Mostrar el nombre de cada muestra junto con el nombre de la expedición a la que pertenece y la profundidad de la muestra.
SELECT M.tipo AS tipo_muestra, E.nombre AS expedicion, M.profundidad_m AS profundidad_muestra
FROM expedicion E JOIN muestra M
ON M.id_expedicion = E.id_expedicion;
    
-- CONSULTAS LEFT JOIN
-- 17. Mostrar todas las zonas y el número de expediciones realizadas en cada una, incluyendo las zonas en las que no se haya realizado ninguna expedición.
SELECT Z.nombre AS zona, COUNT(E.id_expedicion) AS num_expediciones_realizadas
FROM zona Z LEFT JOIN expedicion E
ON Z.id_zona = E.id_zona
GROUP BY Z.id_zona, Z.nombre;

-- 18. Mostrar todos los investigadores y el número de expediciones en las que participa cada uno, incluyendo los investigadores que no hayan participado en ninguna.
SELECT I.nombre AS investigador, COUNT(P.id_expedicion) AS num_expediciones_realizadas
FROM investigador I LEFT JOIN participacion P
ON I.id_investigador = P.id_investigador
GROUP BY I.id_investigador, I.nombre;

-- 19. Mostrar todas las expediciones y el número de muestras recogidas en cada una,
-- incluyendo las expediciones en las que no se haya recogido ninguna muestra.
SELECT E.nombre AS expedicion, COUNT(M.id_muestra) AS num_muestras_exp
FROM expedicion E
LEFT JOIN muestra M
ON E.id_expedicion = M.id_expedicion
GROUP BY E.id_expedicion, E.nombre;

-- CONSULTAS COMBINADAS
-- 20. Mostrar el nombre de cada zona y la profundidad media de las muestras recogidas en ella.
SELECT Z.nombre AS zona, AVG(M.profundidad_m) AS profundidad_media_muestras
FROM zona Z
JOIN expedicion E ON Z.id_zona = E.id_zona
JOIN muestra M ON E.id_expedicion = M.id_expedicion
GROUP BY Z.id_zona, Z.nombre;

-- 21. Mostrar el nombre de cada expedición, el nombre de su zona y el número de muestras recogidas.
SELECT E.nombre AS expedicion, Z.nombre AS zona_exp, COUNT(id_muestra) AS num_muestras
FROM expedicion E 
JOIN zona Z ON Z.id_zona = E.id_zona
JOIN muestra M ON E.id_expedicion = M.id_expedicion
GROUP BY E.id_expedicion, E.nombre, Z.nombre;

-- 22. Mostrar las zonas que tengan al menos 2 expediciones.
SELECT Z.nombre, COUNT(E.id_expedicion) AS num_expediciones2oMas
FROM zona Z JOIN expedicion E 
ON Z.id_zona = E.id_zona
GROUP BY Z.id_zona, Z.nombre
HAVING COUNT(E.id_expedicion) >= 2;

-- 23. Mostrar las zonas que tengan al menos 2 expediciones y cuya profundidad media de las muestras sea superior a 500 m.
SELECT Z.nombre, COUNT(E.id_expedicion) AS num_expediciones2oMas, AVG(M.profundidad_m) AS media_profundidad_muestras_superior500m
FROM expedicion E 
JOIN zona Z ON E.id_zona = Z.id_zona
JOIN muestra M ON E.id_expedicion = M.id_expedicion
GROUP BY Z.id_zona, Z.nombre
HAVING COUNT(E.id_expedicion) >= 2 AND AVG(M.profundidad_m) > 500;

-- 24. Mostrar el nombre del investigador y el número de expediciones en las que participa, ordenando el resultado de mayor a menor.
SELECT I.nombre, COUNT(P.id_expedicion) AS num_expediciones_realizadas
FROM investigador I JOIN participacion P
ON I.id_investigador = P.id_investigador
GROUP BY I.id_investigador, I.nombre
ORDER BY num_expediciones_realizadas DESC;

-- RETO FINAL
-- Mostrar para cada zona:
-- • Nombre de la zona.
-- • Número de expediciones.
-- • Número total de muestras recogidas.
-- Deben aparecer también las zonas que no tengan expediciones ni muestras

SELECT Z.nombre, COUNT(E.id_expedicion) AS num_expediciones_realizadas, COUNT(M.id_muestra) AS num_muestras_recogidas
FROM zona Z
LEFT JOIN expedicion E ON Z.id_zona = E.id_zona
LEFT JOIN muestra M ON E.id_expedicion = M.id_expedicion
GROUP BY Z.id_zona, Z.nombre;