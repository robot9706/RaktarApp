-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2017. Nov 24. 13:48
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

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `partnershipment`
--

CREATE TABLE `partnershipment` (
  `PartnerID` int(11) DEFAULT NULL,
  `ItemID` int(11) DEFAULT NULL,
  `WarehouseID` int(11) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `Count` int(11) DEFAULT NULL,
  `Sell` bit(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `shipment`
--

CREATE TABLE `shipment` (
  `WarehouseFrom` int(11) DEFAULT NULL,
  `WarehouseTo` int(11) DEFAULT NULL,
  `ItemID` int(11) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `Count` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `stock`
--

CREATE TABLE `stock` (
  `ItemID` int(11) DEFAULT NULL,
  `WarehouseID` int(11) DEFAULT NULL,
  `Count` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

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
  ADD UNIQUE KEY `Date` (`Date`),
  ADD KEY `PartnerID` (`PartnerID`),
  ADD KEY `ItemID` (`ItemID`),
  ADD KEY `WarehouseID` (`WarehouseID`);

--
-- A tábla indexei `shipment`
--
ALTER TABLE `shipment`
  ADD UNIQUE KEY `Date` (`Date`),
  ADD KEY `WarehouseFrom` (`WarehouseFrom`),
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
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `item`
--
ALTER TABLE `item`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `partner`
--
ALTER TABLE `partner`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `warehouse`
--
ALTER TABLE `warehouse`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

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
