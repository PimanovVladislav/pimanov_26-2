-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Июн 07 2020 г., 23:56
-- Версия сервера: 5.5.25
-- Версия PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `birjha_truda`
--

-- --------------------------------------------------------

--
-- Структура таблицы `soiskateli`
--

CREATE TABLE IF NOT EXISTS `soiskateli` (
  `id_users` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Фамилия` varchar(50) NOT NULL,
  `Имя` varchar(50) NOT NULL,
  `Отчество` varchar(50) NOT NULL,
  `Пол` varchar(10) NOT NULL,
  `Возраст` int(2) unsigned NOT NULL,
  `Должность` varchar(100) NOT NULL,
  `Паспорт` int(10) unsigned NOT NULL,
  `Информауия о себе` text CHARACTER SET utf8mb4 NOT NULL,
  `Трудовой стаж` int(2) unsigned NOT NULL,
  PRIMARY KEY (`id_users`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Соискатели' AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
