-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2017. Nov 25. 18:46
-- Kiszolgáló verziója: 10.1.28-MariaDB
-- PHP verzió: 7.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `raktar2`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `category`
--

CREATE TABLE `category` (
  `ID` int(11) NOT NULL,
  `Name` varchar(64) COLLATE utf8_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `category`
--

INSERT INTO `category` (`ID`, `Name`) VALUES
(1, 'Egér'),
(2, 'Billentyű'),
(3, 'Monitor'),
(4, 'Gépház'),
(5, 'Processzor'),
(6, 'Videókártya');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `item`
--

CREATE TABLE `item` (
  `ID` int(11) NOT NULL,
  `Name` varchar(64) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `Price` double DEFAULT NULL,
  `Description` varchar(128) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `CategoryID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `item`
--

INSERT INTO `item` (`ID`, `Name`, `Price`, `Description`, `CategoryID`) VALUES
(1, 'Olcsó egér', 500, 'Olcsó egér, jó irodai használatra.', 1),
(2, 'Drága egér', 5000, 'Drága gamer egér, RGB!!', 1),
(3, 'RAZOR gamer billentyű', 10000, 'RAZOR RGB gamer billentyű', 2),
(4, 'Ergonomikus billentyű', 2500, 'Nagyon kényelmes', 2),
(5, 'Nagy monitor', 50000, 'Szinte TV méretű monitor', 3),
(6, 'Kicsi monitor', 25000, 'Van HDMI meg DVI meg minden jó cucc', 3),
(7, 'Fekete gépház', 10000, 'Jókis fekete gépház', 4),
(8, 'Ezüst gépház', 10000, 'Nagyon raj', 4),
(9, 'Intol i55', 75000, '600GHz, 64 mag', 5),
(10, 'ABD Fallen', 5000, 'Advanced Big Electronics processzor', 5),
(11, 'nVideo GXT 9000', 50000, 'PUBG fut rajta 30FPS-el', 6);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `partner`
--

CREATE TABLE `partner` (
  `ID` int(11) NOT NULL,
  `Name` varchar(64) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `PostCode` varchar(16) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `City` varchar(64) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `Street` varchar(64) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `StreetNumber` int(11) DEFAULT NULL,
  `Telephone` varchar(32) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `Email` varchar(32) COLLATE utf8_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `partner`
--

INSERT INTO `partner` (`ID`, `Name`, `PostCode`, `City`, `Street`, `StreetNumber`, `Telephone`, `Email`) VALUES
(1, 'Számítógép építős cég', '6000', 'Főváros', 'Ipari utca', 12, '12 345 6789', 'cég@oldal.hu'),
(2, 'PC kisker', '6700', 'Random város', 'Utca', 52, '23 456 7890', 'kisker@cég.hu'),
(3, 'Egyik beszállító cég', '6002', 'Főváros', 'Beszállitos utca', 32, '65 123 1234', 'beszallito@randomceg.hu'),
(4, 'iPort.hu', '6341', 'Menő város', 'iPortos utca', 23, '72 234 2456', 'vegyecuccot@iport.hu'),
(5, 'Falusi PC bót', '6380', 'Falu', 'Főutca', 64, '98 345 5743', 'email@falupc.hu'),
(6, 'Olcsó PC', '6300', 'Másik kis város', 'Fő út', 12, '92 735 3492', 'olcsó@pc.hu'),
(7, 'Másik beszállító cég', '6820', 'Beszállítós város', 'Beszálítós utca', 34, '32 453 1256', 'szallito@be.hu'),
(8, 'Külföldi beszállító', '9231AB', 'Külföld Város', 'Külföld sugárút', 854, '23 248 643', 'kulfold@szallitos.com');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `partnershipment`
--

CREATE TABLE `partnershipment` (
  `PartnerID` int(11) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `WarehouseID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Count` int(11) DEFAULT NULL,
  `Sell` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `partnershipment`
--

INSERT INTO `partnershipment` (`PartnerID`, `ItemID`, `WarehouseID`, `Date`, `Count`, `Sell`) VALUES
(2, 1, 1, '2017-11-24', 100, 1),
(2, 4, 6, '2017-11-24', 5, 0),
(2, 5, 4, '2017-11-24', 10, 1),
(2, 7, 1, '2017-11-24', 50, 1),
(3, 1, 2, '2017-11-24', 25, 0),
(3, 3, 1, '2017-11-24', 50, 0),
(3, 7, 1, '2017-11-24', 100, 0),
(3, 10, 3, '2017-11-24', 1, 0),
(4, 6, 6, '2017-11-24', 20, 1),
(5, 3, 2, '2017-11-25', 1, 1),
(5, 8, 1, '2017-11-24', 5, 1),
(6, 5, 4, '2017-11-24', 5, 0),
(6, 8, 1, '2017-11-24', 10, 1),
(7, 1, 1, '2017-11-24', 500, 0),
(7, 3, 1, '2017-11-24', 50, 0),
(7, 4, 4, '2017-11-24', 20, 0),
(7, 8, 1, '2017-11-24', 50, 0),
(8, 5, 5, '2017-11-24', 200, 0),
(8, 6, 5, '2017-11-24', 250, 0),
(8, 8, 5, '2017-11-24', 50, 0),
(8, 9, 5, '2017-11-24', 50, 0),
(8, 11, 5, '2017-11-24', 100, 0);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `shipment`
--

CREATE TABLE `shipment` (
  `WarehouseFrom` int(11) NOT NULL,
  `WarehouseTo` int(11) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Count` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `shipment`
--

INSERT INTO `shipment` (`WarehouseFrom`, `WarehouseTo`, `ItemID`, `Date`, `Count`) VALUES
(1, 2, 3, '2017-11-24', 25),
(1, 2, 6, '2017-11-24', 50),
(1, 4, 5, '2017-11-24', 20),
(1, 6, 5, '2017-11-24', 50),
(1, 6, 6, '2017-11-24', 50),
(4, 6, 4, '2017-11-24', 10),
(5, 1, 5, '2017-11-24', 100),
(5, 1, 6, '2017-11-24', 200),
(5, 1, 11, '2017-11-24', 50);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `stock`
--

CREATE TABLE `stock` (
  `ItemID` int(11) DEFAULT NULL,
  `WarehouseID` int(11) DEFAULT NULL,
  `Count` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `stock`
--

INSERT INTO `stock` (`ItemID`, `WarehouseID`, `Count`) VALUES
(3, 1, 75),
(1, 2, 25),
(7, 1, 50),
(8, 1, 35),
(3, 2, 24),
(4, 4, 10),
(5, 5, 100),
(8, 5, 50),
(11, 5, 50),
(11, 1, 50),
(5, 1, 30),
(5, 6, 50),
(5, 4, 15),
(1, 1, 400),
(9, 5, 50),
(10, 3, 1),
(6, 5, 50),
(6, 1, 100),
(6, 2, 50),
(6, 6, 30),
(4, 6, 15);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `warehouse`
--

CREATE TABLE `warehouse` (
  `ID` int(11) NOT NULL,
  `Name` varchar(64) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `PostCode` varchar(16) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `City` varchar(64) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `Street` varchar(64) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `StreetNumber` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `warehouse`
--

INSERT INTO `warehouse` (`ID`, `Name`, `PostCode`, `City`, `Street`, `StreetNumber`) VALUES
(1, 'Fő raktár', '6000', 'Nagyváros', 'Ipair utca', 50),
(2, 'Elosztó raktár', '6500', 'Random kis város', 'Út', 90),
(3, 'Nem használt raktár', '6001', 'Nagyváros', 'Mellék utca', 2),
(4, 'Kisebb raktár', '6300', 'Másik kis város', 'Fő út', 132),
(5, 'Külföldi raktár', 'XY46', 'Das Város', 'Utza', 6363),
(6, 'Másik elosztó raktár', '6200', 'Mégegy város', 'Valami utca', 71);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`ID`);

--
-- A tábla indexei `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `CategoryID` (`CategoryID`);

--
-- A tábla indexei `partner`
--
ALTER TABLE `partner`
  ADD PRIMARY KEY (`ID`);

--
-- A tábla indexei `partnershipment`
--
ALTER TABLE `partnershipment`
  ADD PRIMARY KEY (`PartnerID`,`ItemID`,`WarehouseID`,`Date`),
  ADD KEY `ItemID` (`ItemID`),
  ADD KEY `WarehouseID` (`WarehouseID`);

--
-- A tábla indexei `shipment`
--
ALTER TABLE `shipment`
  ADD PRIMARY KEY (`WarehouseFrom`,`WarehouseTo`,`ItemID`,`Date`),
  ADD KEY `WarehouseTo` (`WarehouseTo`),
  ADD KEY `ItemID` (`ItemID`);

--
-- A tábla indexei `stock`
--
ALTER TABLE `stock`
  ADD KEY `ItemID` (`ItemID`),
  ADD KEY `WarehouseID` (`WarehouseID`);

--
-- A tábla indexei `warehouse`
--
ALTER TABLE `warehouse`
  ADD PRIMARY KEY (`ID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `category`
--
ALTER TABLE `category`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT a táblához `item`
--
ALTER TABLE `item`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT a táblához `partner`
--
ALTER TABLE `partner`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT a táblához `warehouse`
--
ALTER TABLE `warehouse`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `item`
--
ALTER TABLE `item`
  ADD CONSTRAINT `item_ibfk_1` FOREIGN KEY (`CategoryID`) REFERENCES `category` (`ID`);

--
-- Megkötések a táblához `partnershipment`
--
ALTER TABLE `partnershipment`
  ADD CONSTRAINT `partnershipment_ibfk_1` FOREIGN KEY (`PartnerID`) REFERENCES `partner` (`ID`),
  ADD CONSTRAINT `partnershipment_ibfk_2` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ID`),
  ADD CONSTRAINT `partnershipment_ibfk_3` FOREIGN KEY (`WarehouseID`) REFERENCES `warehouse` (`ID`);

--
-- Megkötések a táblához `shipment`
--
ALTER TABLE `shipment`
  ADD CONSTRAINT `shipment_ibfk_1` FOREIGN KEY (`WarehouseFrom`) REFERENCES `warehouse` (`ID`),
  ADD CONSTRAINT `shipment_ibfk_2` FOREIGN KEY (`WarehouseTo`) REFERENCES `warehouse` (`ID`),
  ADD CONSTRAINT `shipment_ibfk_3` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ID`);

--
-- Megkötések a táblához `stock`
--
ALTER TABLE `stock`
  ADD CONSTRAINT `stock_ibfk_1` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ID`),
  ADD CONSTRAINT `stock_ibfk_2` FOREIGN KEY (`WarehouseID`) REFERENCES `warehouse` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
