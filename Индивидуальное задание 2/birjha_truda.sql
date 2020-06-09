-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Июн 09 2020 г., 13:45
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
-- Структура таблицы `companies`
--

CREATE TABLE IF NOT EXISTS `companies` (
  `id_Company` int(11) NOT NULL AUTO_INCREMENT,
  `Company` varchar(100) NOT NULL,
  `Region` varchar(50) NOT NULL,
  `Kont_data` text NOT NULL,
  `Prof_Napr` varchar(200) NOT NULL,
  `Type` varchar(20) NOT NULL,
  `Info` text NOT NULL,
  PRIMARY KEY (`id_Company`),
  UNIQUE KEY `Company` (`Company`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Дамп данных таблицы `companies`
--

INSERT INTO `companies` (`id_Company`, `Company`, `Region`, `Kont_data`, `Prof_Napr`, `Type`, `Info`) VALUES
(1, 'Google', 'Russia', 'Alex 4-07-75', 'Programming', 'Коммерческая компани', 'Типо что-то там'),
(2, 'Microsoft', 'USA', 'Gates 2-54-66', 'Programming', 'Коммерческая компани', 'Тоже пара ласковых словечек');

-- --------------------------------------------------------

--
-- Структура таблицы `rezume`
--

CREATE TABLE IF NOT EXISTS `rezume` (
  `User` int(11) unsigned NOT NULL,
  `Doljnost` varchar(50) NOT NULL,
  `Oklad` int(11) NOT NULL,
  `Staj` int(11) NOT NULL,
  `Region` varchar(50) NOT NULL,
  `Graphic` varchar(50) NOT NULL,
  `Info` text NOT NULL,
  KEY `User` (`User`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `soiskateli`
--

CREATE TABLE IF NOT EXISTS `soiskateli` (
  `id_users` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `Last_name` varchar(50) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Father_name` varchar(50) NOT NULL,
  `Pol` varchar(10) NOT NULL,
  `Age` int(2) unsigned NOT NULL,
  `Pasport` int(10) unsigned NOT NULL,
  `Info` text NOT NULL,
  PRIMARY KEY (`id_users`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Соискатели' AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Структура таблицы `vacansii`
--

CREATE TABLE IF NOT EXISTS `vacansii` (
  `id_vakansii` int(11) NOT NULL AUTO_INCREMENT,
  `Doljnost` varchar(200) NOT NULL,
  `Oklad` int(10) NOT NULL,
  `Trebovaniya` text NOT NULL,
  `Company` varchar(100) NOT NULL,
  `Region` varchar(50) NOT NULL,
  `Opisanie_raboti` text NOT NULL,
  PRIMARY KEY (`id_vakansii`),
  KEY `Company` (`Company`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Дамп данных таблицы `vacansii`
--

INSERT INTO `vacansii` (`id_vakansii`, `Doljnost`, `Oklad`, `Trebovaniya`, `Company`, `Region`, `Opisanie_raboti`) VALUES
(1, 'Программист', 10000, '1С, С++, php, sql', 'Google', 'Russia', 'сидеть и валять дурака'),
(2, 'Программист', 78, 'шоло', 'Microsoft', 'Russia', 'ррр');

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `rezume`
--
ALTER TABLE `rezume`
  ADD CONSTRAINT `rezume_ibfk_1` FOREIGN KEY (`User`) REFERENCES `soiskateli` (`id_users`);

--
-- Ограничения внешнего ключа таблицы `vacansii`
--
ALTER TABLE `vacansii`
  ADD CONSTRAINT `vacansii_ibfk_1` FOREIGN KEY (`Company`) REFERENCES `companies` (`Company`) ON DELETE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
