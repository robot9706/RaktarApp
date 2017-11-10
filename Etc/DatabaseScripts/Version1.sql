-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2017. Nov 08. 21:01
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
-- Adatbázis: `raktar`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `category`
--

CREATE TABLE `category` (
  `CategoryID` int(11) NOT NULL,
  `Name` text COLLATE latin2_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `items`
--

CREATE TABLE `items` (
  `ItemID` int(11) NOT NULL,
  `Name` text COLLATE latin2_hungarian_ci NOT NULL,
  `Price` double NOT NULL,
  `Description` text COLLATE latin2_hungarian_ci NOT NULL,
  `CategoryID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `partner`
--

CREATE TABLE `partner` (
  `ID` int(11) NOT NULL,
  `Name` text COLLATE latin2_hungarian_ci NOT NULL,
  `PostCode` text COLLATE latin2_hungarian_ci NOT NULL,
  `City` text COLLATE latin2_hungarian_ci NOT NULL,
  `Street` text COLLATE latin2_hungarian_ci NOT NULL,
  `StreetNumber` int(11) NOT NULL,
  `Telephone` text COLLATE latin2_hungarian_ci NOT NULL,
  `Email` text COLLATE latin2_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `partnershipment`
--

CREATE TABLE `partnershipment` (
  `PartnerID` int(11) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `WarehouseID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Count` int(11) NOT NULL,
  `Sell` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `shipment`
--

CREATE TABLE `shipment` (
  `WarehouseFrom` int(11) NOT NULL,
  `WarehouseTo` int(11) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Count` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `stock`
--

CREATE TABLE `stock` (
  `ItemID` int(11) NOT NULL,
  `Warehouse` int(11) NOT NULL,
  `Count` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `warehouse`
--

CREATE TABLE `warehouse` (
  `ID` int(11) NOT NULL,
  `Name` text COLLATE latin2_hungarian_ci NOT NULL,
  `PostCode` text COLLATE latin2_hungarian_ci NOT NULL,
  `City` text COLLATE latin2_hungarian_ci NOT NULL,
  `Street` text COLLATE latin2_hungarian_ci NOT NULL,
  `StreetNumber` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`CategoryID`);

--
-- A tábla indexei `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`ItemID`),
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
  ADD KEY `PartnerID` (`PartnerID`),
  ADD KEY `ItemID` (`ItemID`),
  ADD KEY `WarehouseID` (`WarehouseID`);

--
-- A tábla indexei `shipment`
--
ALTER TABLE `shipment`
  ADD KEY `WarehouseTo` (`WarehouseTo`),
  ADD KEY `ItemID` (`ItemID`),
  ADD KEY `WarehouseFrom` (`WarehouseFrom`);

--
-- A tábla indexei `stock`
--
ALTER TABLE `stock`
  ADD KEY `ItemID` (`ItemID`),
  ADD KEY `Warehouse` (`Warehouse`);

--
-- A tábla indexei `warehouse`
--
ALTER TABLE `warehouse`
  ADD PRIMARY KEY (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
