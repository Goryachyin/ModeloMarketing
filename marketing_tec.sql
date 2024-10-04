-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 05-10-2024 a las 00:58:42
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `marketing_tec`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `id_cliente` int(9) NOT NULL,
  `noControl_cliente` varchar(8) NOT NULL,
  `nombre_cliente` varchar(20) NOT NULL,
  `apellidoP_cliente` varchar(20) NOT NULL,
  `edad_cliente` int(2) NOT NULL,
  `telefono_cliente` varchar(13) NOT NULL,
  `correo_cliente` varchar(40) NOT NULL,
  `contraseña_cliente` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `orden`
--

CREATE TABLE `orden` (
  `ID_ORDEN` int(9) NOT NULL,
  `ID_CLIENTE` int(9) NOT NULL,
  `ID_PRO` varchar(22) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `FECHA_ORDEN` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `ID_PRO` varchar(22) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ID_VENDEDOR` int(9) NOT NULL,
  `NOMBRE_P` varchar(20) NOT NULL,
  `PRECIO_P` decimal(10,2) NOT NULL,
  `DISPONIBILIDAD_P` tinyint(1) NOT NULL,
  `CATEGORIA_P` varchar(15) NOT NULL,
  `TAMAÑO_P` varchar(40) NOT NULL,
  `LISTA_ENTREGA` tinyint(1) NOT NULL,
  `POR_ENCARGO` tinyint(1) NOT NULL,
  `CALIFICACIÓN_P` int(3) NOT NULL,
  `DETALLES_O` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `id_usuario` varchar(8) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `nombre_usuario` varchar(25) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `correo_usuario` varchar(30) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `password_usuario` varchar(25) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `fecha_usuario` date NOT NULL,
  `carrera_usuario` varchar(50) NOT NULL,
  `imagen_usuario` longblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id_usuario`, `nombre_usuario`, `correo_usuario`, `password_usuario`, `fecha_usuario`, `carrera_usuario`, `imagen_usuario`) VALUES

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vendedor`
--

CREATE TABLE `vendedor` (
  `ID_VENDEDOR` int(9) NOT NULL,
  `NOMBRE_V` varchar(15) NOT NULL,
  `APELLIDOP_V` varchar(15) NOT NULL,
  `EDAD_V` int(2) NOT NULL,
  `TELEFONO_V` varchar(13) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `CORREO_V` varchar(40) NOT NULL,
  `CONTRA_V` varchar(30) NOT NULL,
  `CALIFICACIÓN` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cliente`);

--
-- Indices de la tabla `orden`
--
ALTER TABLE `orden`
  ADD PRIMARY KEY (`ID_ORDEN`),
  ADD KEY `ID_CLIENTE` (`ID_CLIENTE`),
  ADD KEY `ID_PRODUCTO` (`ID_PRO`),
  ADD KEY `ID_PRO` (`ID_PRO`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`ID_PRO`),
  ADD KEY `ID_VENDEDOR` (`ID_VENDEDOR`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usuario`);

--
-- Indices de la tabla `vendedor`
--
ALTER TABLE `vendedor`
  ADD PRIMARY KEY (`ID_VENDEDOR`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `orden`
--
ALTER TABLE `orden`
  ADD CONSTRAINT `orden_ibfk_1` FOREIGN KEY (`ID_CLIENTE`) REFERENCES `cliente` (`id_cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `orden_ibfk_2` FOREIGN KEY (`ID_PRO`) REFERENCES `producto` (`ID_PRO`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `producto`
--
ALTER TABLE `producto`
  ADD CONSTRAINT `producto_ibfk_1` FOREIGN KEY (`ID_VENDEDOR`) REFERENCES `vendedor` (`ID_VENDEDOR`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;