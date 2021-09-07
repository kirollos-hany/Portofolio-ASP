-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Sep 07, 2021 at 06:40 PM
-- Server version: 8.0.26
-- PHP Version: 7.4.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `portofoliodb`
--

-- --------------------------------------------------------

--
-- Table structure for table `aspnetroleclaims`
--

CREATE TABLE `aspnetroleclaims` (
  `Id` int NOT NULL,
  `RoleId` int NOT NULL,
  `ClaimType` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `ClaimValue` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetroles`
--

CREATE TABLE `aspnetroles` (
  `Id` int NOT NULL,
  `Name` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `NormalizedName` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int NOT NULL,
  `UserId` int NOT NULL,
  `ClaimType` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `ClaimValue` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserlogins`
--

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProviderKey` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProviderDisplayName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `UserId` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserroles`
--

CREATE TABLE `aspnetuserroles` (
  `UserId` int NOT NULL,
  `RoleId` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetusers`
--

CREATE TABLE `aspnetusers` (
  `Id` int NOT NULL,
  `ImagePath` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT '~/img/avatar.png',
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) NOT NULL,
  `UserName` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '',
  `NormalizedUserName` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Email` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '',
  `NormalizedEmail` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `SecurityStamp` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `PhoneNumber` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT 'Not Assigned',
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int NOT NULL,
  `Specialization` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `aspnetusers`
--

INSERT INTO `aspnetusers` (`Id`, `ImagePath`, `CreatedAt`, `UpdatedAt`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`, `Specialization`) VALUES
(1, 'Exercitationem neque et atque praesentium et aperiam. Qui excepturi sit quis excepturi possimus vel aut.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Prof. Hershel Schuppe', NULL, 'caitlyn.towne@bins.com', NULL, 0, '289-23-5783', NULL, '07f6f2c4-db7d-408e-a5ca-015f1e14c838', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(2, 'Et molestiae aliquid consequatur et. Sit beatae laboriosam et dolore minus. Voluptatem corporis est harum quos ut odit minus molestiae. Autem voluptatem eius autem et accusamus.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Arch Hilpert', NULL, 'mylene.brekke@cruickshank.biz', NULL, 0, '396-74-9235', NULL, '3056e139-6ec7-4866-8f04-d2362f157035', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(3, 'Corporis sed rerum quia maiores sit voluptas. Harum inventore voluptatem minima ullam quia dolores laboriosam.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Assunta Jakubowski', NULL, 'emmy_rogahn@hilpertraynor.biz', NULL, 0, '541-97-6914', NULL, '84be5427-8b72-4027-8d6e-bd1e0585fc89', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(4, 'Tempore eveniet et laborum corrupti. Qui provident distinctio maiores laborum quo.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Mabel Mills DDS', NULL, 'jeanie_schuppe@ernserpfannerstill.co.uk', NULL, 0, '603-05-4173', NULL, '36b287f9-bfd5-4b5b-8ca4-69537a5e0f94', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(5, 'Aliquam consequatur a aut mollitia ex alias porro. Ut qui debitis similique consequatur.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Leonie Donnelly', NULL, 'madalyn@kirlin.co.uk', NULL, 0, '069-78-4929', NULL, '6dc4d89e-2eb2-45e1-b56e-ebd66d6ed340', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(6, 'Similique ex temporibus aut ut cumque tempora aliquam rem molestiae. Perferendis et dolores vitae minus ratione vero. Voluptate enim voluptas accusamus labore. Dolore consequatur et non at autem nihil est voluptatem iusto.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Tamara Carmine Sauer DVM', NULL, 'everardo@bogisich.uk', NULL, 0, '270-59-4491', NULL, 'f81623e9-1c80-40c3-a861-42fe8e67c8b1', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(7, 'Laborum est assumenda vero possimus dolores aliquam et ut. Dolorem voluptas aliquid labore magni. Fuga qui aspernatur sint recusandae.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Ms. Erna Strosin PhD', NULL, 'neoma.volkman@torphygoldner.us', NULL, 0, '134-32-6803', NULL, 'b40ca34a-a18f-4f40-84a7-8724e3d0ac2d', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(8, 'Voluptatem et et aperiam libero ab non odio quod. Incidunt voluptatem illum incidunt rem veniam explicabo. Numquam aliquam architecto ipsam debitis distinctio quo. Exercitationem sunt corrupti molestias.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Ms. Kristofer O\'Reilly', NULL, 'jacey@krajcik.uk', NULL, 0, '029-84-5182', NULL, '912712dd-c60f-48a7-be5e-a5f449fb277d', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(9, 'Sit quis ab numquam ea occaecati.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Mr. Graham Malvina Stamm I', NULL, 'leo@bruen.biz', NULL, 0, '575-49-8358', NULL, '6cd426b3-d519-4ac5-b0b9-9b3469c4cdef', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(10, 'Molestias ut beatae pariatur consequatur esse. Eum consequatur sint eum eligendi consequatur et ea perspiciatis.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Clark Watsica', NULL, 'jessy_schaden@kochcummings.biz', NULL, 0, '108-94-6663', NULL, '572cf113-d9b0-49c9-b273-4815ee056e6f', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(11, 'Delectus mollitia voluptates quis a iusto ut voluptatibus quia et. Sunt eos corporis asperiores. Molestiae dicta libero laborum nihil quas repellendus. Maxime vitae eligendi perspiciatis dolores voluptas.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Prof. Lance Eugenia Kohler I', NULL, 'margie_anderson@mills.co.uk', NULL, 0, '557-46-2938', NULL, '26f44475-72a3-425e-afc2-7afd44d584d5', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(12, 'Consequatur ullam hic nesciunt inventore iusto iste saepe recusandae veritatis.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Mr. Paul Joanie Murray', NULL, 'ernest_gutkowski@huelosinski.uk', NULL, 0, '010-71-4951', NULL, '50c338d9-3392-489c-8cdc-30a0cef62d4a', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(13, 'Reiciendis neque velit explicabo delectus impedit inventore corrupti. Laborum nam maxime ut quia. Ad dolorum sit dolores voluptatem.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Lorna Bode', NULL, 'kennedi@thompson.uk', NULL, 0, '253-71-7110', NULL, '1517b594-0ef6-4737-b535-fc77f7848338', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(14, 'Aut modi magnam asperiores fuga fugiat molestiae sequi blanditiis. Omnis expedita laudantium libero minus.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Ms. Precious Kuvalis Jr.', NULL, 'jazlyn@blockdaugherty.biz', NULL, 0, '132-19-5064', NULL, 'ed2350c5-b2d5-493a-b075-ce807fc57c95', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(15, 'Aut repudiandae tempora accusamus. Adipisci incidunt harum et.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Juston DuBuque', NULL, 'nadia.little@zboncakcummings.uk', NULL, 0, '425-40-4463', NULL, '430f6ea6-c932-45d1-b7ba-1bc5d2a554ca', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(16, 'Non impedit ut facilis molestiae libero labore asperiores voluptatem tempora.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Eliza Gerhold', NULL, 'tracy.hauck@funk.info', NULL, 0, '386-45-6081', NULL, '2ea9492b-48ed-432f-955a-ea80989ada8b', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(17, 'Nihil aut vero voluptatem provident eveniet illum nemo sint deserunt. Dignissimos accusantium suscipit aut ut.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Nona Kuhn', NULL, 'rudy_hansen@stroman.ca', NULL, 0, '157-09-3862', NULL, 'f5a12aba-2c0a-4611-9e08-0483b55a493a', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(18, 'Minus deserunt debitis quod ratione quidem. Voluptatem aut autem maiores pariatur quae iste. Soluta amet fuga earum vitae quibusdam saepe consequatur facilis.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Parker Gerhold', NULL, 'gillian@schumm.ca', NULL, 0, '480-25-8869', NULL, '96604ea4-0c13-43df-a13f-9da9c487a07f', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(19, 'Et qui quis qui.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Lyla Lind', NULL, 'abigayle_brown@ryanmurray.biz', NULL, 0, '231-90-4426', NULL, '86d53582-a65e-4de0-8b3b-c093ee326d0d', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(20, 'Omnis nobis voluptatibus consequatur iusto eos eos sunt.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Janie McDermott', NULL, 'adeline@nader.co.uk', NULL, 0, '351-35-6159', NULL, '5fd61082-6da7-49d7-a24b-819434be5111', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(21, 'Magnam omnis nisi commodi. Accusamus sed qui odit vel quas minima. Suscipit assumenda quo impedit sequi.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Renee Mayert', NULL, 'franz@predovicbashirian.uk', NULL, 0, '377-05-5597', NULL, 'd6cdfc34-d967-4206-a493-8cda9fcd18a1', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(22, 'Necessitatibus suscipit consequatur laborum ea consequuntur atque illo. Odit necessitatibus eligendi alias.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Marques Kub', NULL, 'ernesto@howell.biz', NULL, 0, '208-50-7388', NULL, '92824693-8e54-4035-b61f-af2d0af8c930', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(23, 'Quae excepturi autem temporibus beatae. Qui atque asperiores error soluta sed dolorum dolorum reiciendis explicabo. Omnis et dolores aut temporibus hic. Officiis vel voluptatum at.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Mr. Monica Malika Morar', NULL, 'summer@konopelski.info', NULL, 0, '009-31-5499', NULL, 'b1c0d6cd-3a64-48a2-a429-9d641dc09f2e', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(24, 'Adipisci voluptatem officia voluptatum adipisci dolorum. Voluptate vel id temporibus. Consequatur sit voluptatem rerum qui dolorem vel aut.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Alayna Torphy II', NULL, 'cole@gleichner.us', NULL, 0, '006-11-5684', NULL, '8b4679a8-1097-4c59-950c-4aa1e6e1437a', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(25, 'Eum et sed sunt omnis saepe maiores laboriosam vel. Magni excepturi occaecati aut a. Repudiandae ut repellat necessitatibus fuga aut.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Brooks Stamm', NULL, 'valentina@dickinson.info', NULL, 0, '512-49-8098', NULL, '7f474a87-7682-47c5-832a-094aafa25495', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(26, 'Est rerum aperiam et est error ipsa amet omnis.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Prof. Bryon Arlene Dooley DVM', NULL, 'hershel@volkman.us', NULL, 0, '072-34-9306', NULL, '45419501-6ec3-45f2-9da2-c96526d73624', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(27, 'Rerum eum earum cumque dolores non tempore.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Dr. Malvina Mabel Sawayn', NULL, 'kelsi_baumbach@schulist.uk', NULL, 0, '008-92-4975', NULL, '020d019a-9492-4af0-9cb3-272cefa3d390', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(28, 'Placeat aut sed iste non tempora et sit enim quod. Et labore rerum debitis adipisci sit dignissimos.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Korey Conn', NULL, 'cathryn.satterfield@bernier.us', NULL, 0, '013-35-9678', NULL, 'b402906f-e6dc-4bb5-9282-206bd98c4cc6', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(29, 'Atque eos ipsum reiciendis ratione dolorem ea beatae nihil sint. Tempore illo consectetur iusto maxime unde vel numquam dignissimos nisi.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Dr. Emma Kuvalis IV', NULL, 'albertha@walter.biz', NULL, 0, '342-98-7338', NULL, '07eb08eb-50e6-4a8b-b603-e2739f919c26', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(30, 'Modi velit et quae enim nisi hic neque ad a. Dolorem repellat maxime culpa velit ut numquam voluptatem dolore id. Sapiente dicta nostrum enim dignissimos autem.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Augustus Mitchell', NULL, 'lilly@greenfelderlangworth.biz', NULL, 0, '597-98-9850', NULL, '366c5b24-9351-4ff0-a4a1-2f9747286d23', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(31, 'Facilis aut corrupti non eveniet sapiente eligendi itaque ad doloribus. Assumenda cum est et at omnis sit corporis autem.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Kyle Wanda Nolan MD', NULL, 'leda@tillmanhirthe.uk', NULL, 0, '027-54-8317', NULL, '1a46a025-5798-4a3f-9223-63f08eefd37e', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(32, 'Suscipit ut reprehenderit non enim ad.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Lizeth Cremin', NULL, 'genevieve@russel.ca', NULL, 0, '636-12-4588', NULL, '3dba074b-9e22-4308-98c9-9423b5d09bf9', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(33, 'Maiores excepturi qui quasi eligendi placeat.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Golden Luettgen', NULL, 'humberto.dach@miller.co.uk', NULL, 0, '539-90-1359', NULL, '6bded488-596d-42f7-85b2-a41104b403a1', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(34, 'Placeat est quas qui temporibus. Cupiditate animi deserunt iusto.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Dr. Wilfred Stanton', NULL, 'josue_ohara@bodekoepp.com', NULL, 0, '208-66-3912', NULL, '04742abd-5b0b-48ab-928d-c832bd974bec', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(35, 'Possimus aliquid recusandae inventore aspernatur qui magnam. Reprehenderit sed sit vitae qui tempora voluptatibus. Id et esse eos eos recusandae dolorum. Harum et architecto consequuntur autem omnis voluptatem et qui quia.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Leonard Jacobs', NULL, 'josue_bins@westgrimes.biz', NULL, 0, '401-09-3155', NULL, '2ed2f66b-9db2-40ca-a205-adab3afb87ea', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(36, 'Perspiciatis totam quis aut.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Kyleigh Medhurst', NULL, 'june.skiles@bahringerebert.biz', NULL, 0, '443-78-6932', NULL, '64ff5f3a-fa95-4a51-bbf8-165e33494def', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(37, 'Exercitationem dolores et enim similique dolores ea. Beatae est quo optio expedita eos magni. Vel voluptatem ut nisi vero et recusandae qui error quisquam.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Marlee Sawayn', NULL, 'elmira_funk@wiza.biz', NULL, 0, '618-37-8411', NULL, 'e7dc5fe7-c74b-4ffc-92c2-add5bc0895a0', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(38, 'Vel culpa accusamus corrupti sunt. Est aut quia deleniti optio. Ducimus occaecati vero earum incidunt tenetur quae nesciunt.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Prof. Geovanny Mertz', NULL, 'stevie@bode.us', NULL, 0, '146-51-9606', NULL, 'b7be64fa-3d8d-4cca-9adb-1e3372d5ab9e', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(39, 'Sed impedit eius et quaerat nisi laudantium.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Leda Effertz', NULL, 'dejuan@aufderharbatz.biz', NULL, 0, '049-04-9377', NULL, 'fb493d36-0fd5-483a-9093-a4aa32059f32', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(40, 'Hic non ipsam commodi et illo. Velit consequatur iste esse incidunt eligendi officia ad. Quo velit ut qui ab. Ad amet officia sit.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Nakia Torp II', NULL, 'eleazar@streich.com', NULL, 0, '300-38-2815', NULL, '38c1554b-9aac-4b92-aac2-a381ef07b0f7', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(41, 'Blanditiis at rem omnis. Labore iure atque modi. Consequatur adipisci esse quaerat mollitia aut eaque sunt.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Vivian Willms', NULL, 'itzel@durganfisher.us', NULL, 0, '282-95-6526', NULL, '8115647f-ae14-43a7-bc75-50fef9b6a5c6', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(42, 'Inventore dignissimos temporibus odio dolore iure tempore necessitatibus. Asperiores perspiciatis est autem eius placeat. Placeat eum totam velit dolores nostrum voluptas perferendis autem placeat. Ipsam eligendi voluptatem iure libero.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Mr. Breana Carmela Abshire', NULL, 'leopoldo_wyman@gutmann.uk', NULL, 0, '431-27-9177', NULL, '8a4b539c-411a-4b32-823f-4e4106162be4', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(43, 'Dolorem amet soluta vel et.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Santa Darren Zboncak III', NULL, 'arianna.dach@hamillkshlerin.us', NULL, 0, '102-59-2989', NULL, '8e80eaf8-e089-4e8c-8125-e5d47abad817', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(44, 'Omnis facilis iusto ullam. Eveniet et velit veritatis molestiae nulla quae. Quis magni eum et sit amet.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Modesta Torp', NULL, 'cecelia@stiedemann.biz', NULL, 0, '483-95-3875', NULL, '8fb26726-aaf1-42a5-a2c6-cb2ba2283bc1', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(45, 'Explicabo aut quis facilis dolorum et optio repellendus dolorem voluptas. Et sed et eos. Rerum ratione sed perferendis deserunt natus unde a.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Julius Rowe', NULL, 'marty@hirthe.uk', NULL, 0, '435-60-0430', NULL, '4c8066c4-93cf-422e-80f5-03178714fa53', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(46, 'Architecto atque quidem rerum est nihil quis quaerat. Atque id vitae corporis et harum. Suscipit voluptatum occaecati totam placeat. Ut quia esse voluptatem nesciunt aut et.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Lavina Stanton', NULL, 'alia_hauck@casperjones.com', NULL, 0, '619-16-7228', NULL, '691ecadb-345f-4797-93a1-3bfd9a0b072c', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(47, 'Nihil exercitationem quam sapiente nam tempore. Inventore provident tenetur fugit ut voluptatem adipisci hic consequuntur.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Toy Ortiz', NULL, 'derick@waterseichmann.uk', NULL, 0, '332-59-1813', NULL, 'b2e3c961-b9c4-4267-9903-97c16ae563d5', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(48, 'Et perferendis ut quas est laborum qui repudiandae accusamus. Delectus excepturi qui dolorem.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Marian Mosciski', NULL, 'elvera_damore@volkmanjohnson.name', NULL, 0, '047-34-3743', NULL, '639c9fde-7ea3-4c8b-b4e9-b3d302b1b5bb', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(49, 'Optio ut nihil ut architecto excepturi vero est necessitatibus eos.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Dr. Alexandro Nicolas', NULL, 'isai@morissettekozey.us', NULL, 0, '110-89-1601', NULL, '899abbe8-c62c-4c0c-b3f7-0f2be73cc96a', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(50, 'Ut reprehenderit rerum a voluptatem inventore officia. Non enim sint sit et molestiae ducimus. Perferendis molestiae expedita architecto cum qui beatae voluptas voluptas. Quam sed tenetur dolorem facere earum ab.', '2021-08-23 19:15:22.000000', '2021-08-23 19:15:22.000000', 'Ms. Lelia Vandervort Jr.', NULL, 'hollie@gleichner.uk', NULL, 0, '252-29-4601', NULL, '5f9261d8-297d-4778-a79a-b9af9065faad', '+201206784139', 0, 0, NULL, 0, 0, 'Backend Developer'),
(58, 'Images/Users\\2f6a365b-fcff-4b76-a0d6-a2583e5d3d8b.jpeg', '2021-08-26 14:41:44.306244', '2021-08-26 14:13:58.239175', 'Kirollos Hany', 'KIROLLOS HANY', 'kirolloshany9999@gmail.com', 'KIROLLOSHANY9999@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEH2smken8iztt7DljRfbkKTpeJni5Ctqekt8ljs95/0zEsKA9XoF81R4g3vfcok6bQ==', 'CKRCWI7Y5IFWFCPH6XYTGXHEFD2AG72F', 'b4c996d6-f7ca-4231-8ab7-47b0c0654979', '+201206784139', 0, 0, NULL, 1, 0, 'Back End Developer'),
(59, 'Images/Users\\497588c2-48c3-4fbf-abe3-a634c0a3507c.jpeg', '2021-08-25 09:43:57.410932', '2021-08-25 10:06:31.125981', 'Abanoub Rafaat', 'ABANOUB RAFAAT', 'bebo@gmail.com', 'BEBO@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEI0EOfH1O2tXFqQdVcimXqERyOWQ0PfFSw40x3UQVnuA46L1TTp25z/gD6yETHWmyg==', 'XH65JIPI74YRRFLH6YQYE5KYWODWCSNK', '224c4efd-85db-4531-9d5d-2dd7efe90e90', '+201282692682', 0, 0, NULL, 1, 0, 'Front End Developer'),
(61, '~/img/avatar.png', '2021-08-26 14:41:44.306244', '2021-08-26 14:41:44.306239', 'Gergis Hanna', 'GERGIS HANNA', 'gergishanna@gmail.com', 'GERGISHANNA@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEL97ILlfTPgqFfqfp+Wnviei7mJ7pGe8qC/ikBpFxyz/3hcvX1A4D8ACE1Q5iz+rxw==', 'Q5USBUTN5ATNJ5U2U2IZYJMV2RUAP464', '01823e59-7159-4e70-a471-4901adbb9971', NULL, 0, 0, NULL, 1, 0, 'Back End Developer');

-- --------------------------------------------------------

--
-- Table structure for table `aspnetusertokens`
--

CREATE TABLE `aspnetusertokens` (
  `UserId` int NOT NULL,
  `LoginProvider` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Value` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `contacts`
--

CREATE TABLE `contacts` (
  `Id` int NOT NULL,
  `StatusId` int NOT NULL,
  `ContactName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Phone` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Email` varchar(320) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Message` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedAt` datetime NOT NULL,
  `UpdatedAt` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `contacts`
--

INSERT INTO `contacts` (`Id`, `StatusId`, `ContactName`, `Phone`, `Email`, `Message`, `CreatedAt`, `UpdatedAt`) VALUES
(1, 1, 'Terence Jacobi', '+201206784139', 'graham@lemke.us', 'Sed dolorem commodi corporis quia quasi molestias. Et quis reiciendis ea molestiae laboriosam. Non quaerat dolorum impedit possimus excepturi rerum. Assumenda adipisci et ea sed aliquid reiciendis qui.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(2, 1, 'Miss Neha Littel', '+201206784139', 'herminio@morissette.info', 'Animi rerum saepe repellat ut sed vitae nisi. Deserunt in facere consequatur voluptate sint minus. Et est omnis est magnam dignissimos.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(3, 1, 'Madalyn Labadie', '+201206784139', 'zora@labadie.ca', 'Magni laudantium modi non omnis id alias. Fugiat alias optio deleniti saepe reprehenderit. Non laborum quibusdam aut animi. Eligendi amet est doloremque assumenda minus harum. Iste aut iusto voluptatem.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(4, 1, 'Zella Corkery DVM', '+201206784139', 'ottilie_harber@legrospfannerstill.com', 'Porro repudiandae voluptas recusandae reprehenderit. Occaecati necessitatibus fugit minus adipisci.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(5, 1, 'Jazmyne Brakus', '+201206784139', 'millie@harber.us', 'Impedit et est laudantium eum. A fugiat sint facilis aut occaecati necessitatibus error sed. Ea ea accusantium molestiae autem non autem id aliquid. Et architecto tempore aut recusandae quia.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(6, 1, 'Hiram Hyatt', '+201206784139', 'winifred_stroman@brekke.uk', 'Sint qui dolores eligendi voluptas debitis magnam aut. Voluptatibus tempora qui minus. Asperiores asperiores error odit sequi. Est error dolor eum quisquam ut porro eaque quidem. Adipisci id placeat cum aut vel et.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(7, 1, 'Cordell Bogan', '+201206784139', 'cassie@barton.name', 'Ratione aliquid corrupti sed distinctio consequatur quo aut. Sint possimus dignissimos porro porro occaecati est quaerat. Explicabo reiciendis enim rerum praesentium totam reprehenderit ipsum aperiam. Tempora omnis officia excepturi itaque rerum sequi officia fugiat quae.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(8, 1, 'Abbie Bernhard Sr.', '+201206784139', 'josiah@bruenoconner.com', 'Voluptatibus et sunt et molestias quos et sint. Tempora consequuntur quo sed nobis neque. Odit ea tempora assumenda et. Rerum totam vel dolore. Labore sit voluptatem in.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(9, 1, 'Mr. Kaleigh Bradtke V', '+201206784139', 'odell.friesen@batz.com', 'Odio error dolores sint et. Sit est quia vel quam ad fuga sint nesciunt voluptatibus. Deserunt optio non ut dolores corrupti rerum quia vel blanditiis. Exercitationem tempora voluptas distinctio ut laborum nulla eum.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(10, 1, 'Dr. Emmanuel Cecil Haag', '+201206784139', 'crawford@keeling.name', 'Ipsum eveniet dignissimos atque consequatur aut. Quaerat ut fugiat maiores et veniam et magnam quibusdam. Perferendis architecto voluptatem corporis impedit libero odit sit nulla suscipit. Qui voluptas facere nihil quia fuga nihil vel non. Sapiente numquam repellendus repudiandae omnis alias aspernatur.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(11, 1, 'Meaghan Spinka III', '+201206784139', 'wilfredo_daniel@carroll.co.uk', 'Qui et eos officia nobis distinctio et. Nam eaque consequatur doloribus non aut eum enim non. Molestiae maiores molestiae nam aut atque expedita. Aut repellat maiores officia tempora sit a. Labore voluptas excepturi fugit laborum natus.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(12, 1, 'Miss Kylee Yesenia Luettgen V', '+201206784139', 'marietta.daniel@feeney.name', 'Ut eos molestiae ut eaque et fugit quo. Reprehenderit dolorem aut nesciunt omnis laborum molestiae autem sunt explicabo. Deleniti modi nisi sint culpa est in. Cumque ipsum provident laboriosam totam nam doloribus. Est distinctio consequatur dolorem veniam est dolores.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(13, 1, 'Colt Eichmann', '+201206784139', 'jessica@armstrong.com', 'Ea rem ab ut quibusdam dolor quod ex quis quisquam. Tenetur sed dignissimos at et iure. Totam et debitis doloremque enim dolor.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(14, 1, 'Ms. Vivien Kenneth Gulgowski III', '+201206784139', 'halle.stracke@ortiz.co.uk', 'Sed minima id voluptates non dolorem autem. Recusandae explicabo distinctio reprehenderit voluptatibus at qui omnis pariatur enim.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(15, 1, 'Calista Keven Toy DDS', '+201206784139', 'elmer@zieme.co.uk', 'Ratione saepe ut quis dolores voluptate earum soluta laborum. Qui consectetur nemo et provident assumenda fugit quasi repellendus.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(16, 1, 'Mrs. Eugene Veum V', '+201206784139', 'esperanza@vandervort.biz', 'Autem reprehenderit ipsam neque sapiente corrupti et molestias et recusandae. Dignissimos nihil beatae odit ullam ut sapiente dolores dignissimos similique.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(17, 1, 'Adaline Pollich', '+201206784139', 'kolby_homenick@kub.uk', 'Blanditiis repudiandae reprehenderit ut natus. Sit dignissimos et aut ducimus est iste officia corrupti voluptatem. Voluptas ipsam dicta ut incidunt esse dolor ab. Aut esse necessitatibus quam molestiae quia nam harum maiores.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(18, 1, 'Oleta Kirlin', '+201206784139', 'alford@hermiston.com', 'Nesciunt dolorem quibusdam facere ex fugit similique tenetur. Et optio distinctio tempore tempore aut vel vel eveniet dicta. Eaque hic aliquam voluptatem.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(19, 1, 'Matilde Cole', '+201206784139', 'nichole@stantoncorkery.com', 'Tenetur praesentium molestiae sed. Laboriosam iure nihil et consequatur similique. Distinctio necessitatibus aut impedit quibusdam.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(20, 1, 'Dr. Rudy Reichel', '+201206784139', 'kris@hermistonluettgen.biz', 'Vel dolor omnis et facere ex quibusdam in quae. Molestiae atque ut doloremque consequatur autem voluptas. Voluptas nobis quod quibusdam facere.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(21, 1, 'Mr. Ocie Ariel Lehner', '+201206784139', 'sandra@lindgren.biz', 'Quo sequi placeat non quasi tenetur nostrum nesciunt. Quasi aliquam officiis nesciunt inventore sapiente. Omnis qui eos tempore illum architecto facilis autem mollitia et.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(22, 1, 'Rodrick Langworth', '+201206784139', 'jessica@lowewilliamson.info', 'Minima commodi et sit distinctio voluptatem ab quo. Officiis unde rerum eligendi quisquam voluptatem quia. Deserunt ea aut et culpa a magni dolores. Placeat qui vero accusantium possimus voluptates assumenda.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(23, 1, 'Elta Koelpin', '+201206784139', 'rebekah_macejkovic@nikolausklein.us', 'Eum dolorem ut quis porro. Repellat non quibusdam nostrum autem voluptatibus autem. Voluptas inventore corporis deserunt ad est quo porro cupiditate magni. Deserunt repellat omnis molestiae quo aut quos provident reiciendis.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(24, 1, 'Brycen Bashirian Sr.', '+201206784139', 'tristin@krajcik.ca', 'Explicabo reiciendis voluptatem velit non quasi qui. Qui eum cum quasi harum sequi omnis molestiae voluptatem. Aperiam nisi ut quisquam doloremque. Non quia eaque impedit.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(25, 1, 'Ms. Elna Lulu Braun I', '+201206784139', 'clementina@leannon.info', 'Optio earum possimus aut. Perspiciatis optio aliquam eius ut itaque nostrum perspiciatis velit.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(26, 1, 'Edyth Jacobi Sr.', '+201206784139', 'elaina.bogisich@thiellarkin.co.uk', 'Quam enim adipisci repudiandae ut rerum dolores illo. Voluptatem nemo veritatis voluptatem.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(27, 1, 'Mrs. Efrain Bartoletti', '+201206784139', 'giovani.waelchi@becker.name', 'Ut quisquam beatae modi officia. Laudantium est ipsa eos omnis nihil. Officiis tempore ullam ut consequatur quia commodi dolorem excepturi. Et repudiandae voluptatum in quae tenetur iste et dolorum. Eos consequatur rerum saepe libero incidunt.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(28, 1, 'Miss Bonnie Joany Bogisich', '+201206784139', 'mohammad@manteparisian.name', 'Illo veniam consequatur eum. Minus quia dolores dolorem esse repudiandae laudantium.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(29, 3, 'Mrs. Al Maurine Hilll', '+201206784139', 'eleazar@leffler.com', 'Sapiente distinctio beatae non ea illum. Cupiditate accusantium unde error. Beatae accusantium rem quaerat quasi quibusdam voluptatibus.', '2021-08-23 19:15:22', '2021-08-28 09:50:50'),
(30, 1, 'Ms. Emil Rau', '+201206784139', 'lauren@walter.co.uk', 'Dolores dolorem impedit dolorem beatae. Sed atque minima aspernatur. Dolorum a quidem molestiae totam quaerat quas porro iusto impedit. Nisi aliquam velit explicabo sint provident.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(31, 1, 'Stan Farrell', '+201206784139', 'lucy@schiller.info', 'Veritatis ut sed vero quis accusamus sint placeat. Ipsam repudiandae omnis accusamus sit fuga. Expedita voluptas enim qui est sapiente aliquam saepe nobis expedita.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(32, 1, 'Mr. Alfonso Jonas Spinka', '+201206784139', 'mya_mante@fisher.info', 'Ratione dolorem quia dicta. Inventore sequi expedita debitis veritatis molestiae autem quod ut. Sed qui rerum incidunt et.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(33, 1, 'Aniya King', '+201206784139', 'delfina_gleichner@pfannerstill.name', 'Ea tenetur enim quis eaque reiciendis ut. Qui sed qui quas consequatur ut illo sit cumque.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(34, 1, 'Tracy Adams', '+201206784139', 'sherwood_stanton@lesch.name', 'Ab at eum reiciendis id ipsa qui voluptas. Iure ut ducimus consequatur doloribus doloremque ut. Enim ea voluptas quasi est nemo molestiae in natus.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(35, 1, 'Summer Streich', '+201206784139', 'evangeline@auer.uk', 'Saepe tenetur eius modi voluptatem dolor aperiam vitae et laboriosam. Quia est et eum eius qui est iure dolores dolorem.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(36, 1, 'Mrs. Isobel Schroeder', '+201206784139', 'cordia.emmerich@kleinsporer.biz', 'Omnis eius ut laudantium qui. At facere fuga non enim magnam. Aspernatur dolorem est totam corporis laudantium et sunt incidunt sint. Et voluptas molestiae quia eaque cupiditate dolores quis. Voluptates et saepe velit.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(37, 1, 'Eliezer Purdy', '+201206784139', 'shany@kochlebsack.name', 'Ea omnis sint perferendis corporis consequatur autem sint. Unde distinctio et a nisi facere beatae sint et. Corrupti et perspiciatis enim nisi quidem nemo et dolor. Aperiam aut unde a inventore et.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(38, 1, 'Webster Blick', '+201206784139', 'benny@lind.co.uk', 'Est doloribus repellendus nobis asperiores est rerum in iusto tempore. Numquam doloremque cumque quo et itaque. Necessitatibus rerum eaque dolor.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(39, 1, 'Isabel Hills', '+201206784139', 'danielle_friesen@bahringerdare.us', 'Ut aliquam repudiandae iure. Quaerat sit eaque minima sed omnis.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(40, 1, 'Evalyn Parisian', '+201206784139', 'bridget.vonrueden@gislason.uk', 'In sed autem consequatur ad voluptatibus corrupti unde. Non nulla eos rerum sint illum itaque.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(41, 1, 'Clay Schiller', '+201206784139', 'hope_parisian@lynch.us', 'Eos ea natus similique possimus. Distinctio et ea quo veniam non explicabo. Saepe nesciunt vitae exercitationem voluptatem iusto. Amet tempore doloribus molestiae unde sit provident. Voluptates asperiores sit blanditiis.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(42, 1, 'Gina Naomie Heller DVM', '+201206784139', 'haley@bechtelarshanahan.biz', 'Alias et harum mollitia ipsum. Quo nihil non in nihil.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(43, 1, 'Sandra Bartoletti', '+201206784139', 'benedict_nienow@johnston.com', 'Cupiditate eos voluptatem sit officia et nisi natus totam in. Et et placeat ea nihil eos consequuntur. Ad tempora nam quas consectetur possimus dolor laudantium voluptate et.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(44, 1, 'Daphney Weber', '+201206784139', 'carter.tremblay@starkshields.ca', 'Sint eaque voluptatem commodi dolorum ipsa. Delectus et voluptatum iusto necessitatibus sunt iusto in laboriosam sapiente. Tempore vel possimus vero.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(45, 1, 'Tyra Neil Rogahn MD', '+201206784139', 'juwan@bauchnitzsche.co.uk', 'Velit quo ut doloremque sit possimus excepturi sapiente. Qui quam voluptatum ab assumenda. Est reiciendis aperiam corrupti quo facere nihil blanditiis. Totam corporis adipisci est magnam cupiditate possimus blanditiis a. In sint dolorum voluptatem voluptatem unde.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(46, 1, 'Pete Addison Schamberger DVM', '+201206784139', 'eulah@okon.info', 'Ea laborum ut nesciunt incidunt quis ipsam iste saepe. Eos natus sunt voluptate accusamus quia a id.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(47, 1, 'Ottis Little', '+201206784139', 'madyson@will.uk', 'Deserunt voluptas et aut veritatis soluta voluptatem minima vitae. Error ea saepe magni totam autem soluta dignissimos similique sit. Est perferendis quia doloribus.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(48, 1, 'Marcelino Nienow', '+201206784139', 'cale_bradtke@thompsonpredovic.info', 'Voluptatem fuga quidem voluptatem possimus. Praesentium quod esse totam similique sed aut.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(49, 1, 'Carlo Beer', '+201206784139', 'franz_bednar@hoeger.us', 'Voluptas sunt aspernatur vero qui ipsa. Quibusdam consequatur sed itaque eligendi. Vel error ipsam quia rem. Doloribus debitis quidem quam sit voluptas. Voluptas suscipit aliquam sunt et quas quis eos.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(50, 1, 'Ward Wiza', '+201206784139', 'sophie.friesen@streichaufderhar.name', 'Fuga iste enim et non tempore quaerat non inventore. Molestiae accusantium exercitationem sequi veniam aut adipisci impedit.', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(51, 3, 'Kirollos Hany', '+201206784139', 'kirolloshany9999@gmail.com', 'Testing validation and shit', '2021-08-25 14:16:53', '2021-08-28 09:41:23'),
(52, 1, 'Kirollos Hany', '+201206784139', 'kirolloshany9999@gmail.com', 'Testing validation and shit', '2021-08-25 14:19:09', '0001-01-01 00:00:00'),
(53, 1, 'Kirollos Hany', '+201206784139', 'kirolloshany9999@gmail.com', 'Testing validation and shit', '2021-08-25 14:20:57', '0001-01-01 00:00:00'),
(54, 1, 'Kirollos Hany', '+201206784139', 'kirolloshany9999@gmail.com', 'Message', '2021-08-26 13:00:18', '0001-01-01 00:00:00'),
(55, 1, 'Kirollos Hany', '+201206784139', 'kirolloshany9999@gmail.com', 'Message', '2021-08-26 13:10:18', '0001-01-01 00:00:00'),
(56, 1, 'Kirollos Hany', '+201206784139', 'kirolloshany9999@gmail.com', 'I want a web and desktop application..please get back to me on the price', '2021-08-27 11:22:51', '0001-01-01 00:00:00'),
(57, 1, 'Kirollos Hany', '+201206784139', 'kirolloshany9999@gmail.com', 'I want a web and desktop application..please get back to me on the price', '2021-08-27 11:23:50', '0001-01-01 00:00:00'),
(58, 1, 'Kirollos Hany', '+201206784139', 'kirolloshany9999@gmail.com', 'I want a web and desktop application..please get back to me on the price', '2021-08-27 11:29:48', '0001-01-01 00:00:00'),
(59, 1, 'Kirollos Hany', '+201206784139', 'kirolloshany9999@gmail.com', 'I want a web and desktop application..please get back to me on the price', '2021-08-27 11:31:23', '0001-01-01 00:00:00'),
(60, 1, 'Kirollos Hany', '+201206784139', 'kirolloshany9999@gmail.com', 'I want a web and desktop application..please get back to me on the price', '2021-08-27 11:33:30', '0001-01-01 00:00:00'),
(61, 2, 'Kirollos Hany', '+201206784139', 'kirolloshany9999@gmail.com', 'I want a web and desktop application..please get back to me on the price', '2021-08-27 11:37:35', '2021-08-28 09:40:57'),
(62, 1, 'Kirollos', '+201206784139', 'kirolloshany9999@gmail.com', 'mmmmm', '2021-08-28 18:27:10', '2021-08-28 18:27:10');

-- --------------------------------------------------------

--
-- Table structure for table `contactstatuses`
--

CREATE TABLE `contactstatuses` (
  `Id` int NOT NULL,
  `Status` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedAt` datetime NOT NULL,
  `UpdatedAt` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `contactstatuses`
--

INSERT INTO `contactstatuses` (`Id`, `Status`, `CreatedAt`, `UpdatedAt`) VALUES
(1, 'Pending', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(2, 'In Progress', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(3, 'Completed', '2021-08-23 19:15:22', '2021-08-23 19:15:22');

-- --------------------------------------------------------

--
-- Table structure for table `linktypes`
--

CREATE TABLE `linktypes` (
  `Id` int NOT NULL,
  `LinkType` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedAt` datetime NOT NULL,
  `UpdatedAt` datetime NOT NULL,
  `IconClass` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `linktypes`
--

INSERT INTO `linktypes` (`Id`, `LinkType`, `CreatedAt`, `UpdatedAt`, `IconClass`) VALUES
(1, 'Url', '2021-08-23 19:15:22', '2021-08-23 19:15:22', 'mdi mdi-link\r\n'),
(2, 'Github', '2021-08-23 19:15:22', '2021-08-23 19:15:22', 'mdi mdi-github-box'),
(3, 'LinkedIn', '2021-08-23 19:15:22', '2021-08-23 19:15:22', 'mdi mdi-linkedin-box'),
(4, 'Facebook', '2021-08-23 19:15:22', '2021-08-23 19:15:22', 'mdi mdi-facebook-box');

-- --------------------------------------------------------

--
-- Table structure for table `projectfeedbacks`
--

CREATE TABLE `projectfeedbacks` (
  `Id` int NOT NULL,
  `ProjectId` int NOT NULL,
  `Feedback` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedAt` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `projectfeedbacks`
--

INSERT INTO `projectfeedbacks` (`Id`, `ProjectId`, `Feedback`, `CreatedAt`) VALUES
(51, 60, 'Well done', '2021-09-05 17:30:00');

-- --------------------------------------------------------

--
-- Table structure for table `projectimages`
--

CREATE TABLE `projectimages` (
  `Id` int NOT NULL,
  `ProjectId` int NOT NULL,
  `ImagePath` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedAt` datetime NOT NULL,
  `UpdatedAt` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `projectlinks`
--

CREATE TABLE `projectlinks` (
  `Id` int NOT NULL,
  `ProjectId` int NOT NULL,
  `TypeId` int NOT NULL,
  `Link` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedAt` datetime NOT NULL,
  `UpdatedAt` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `projectlinks`
--

INSERT INTO `projectlinks` (`Id`, `ProjectId`, `TypeId`, `Link`, `CreatedAt`, `UpdatedAt`) VALUES
(75, 60, 1, '#', '2021-09-05 15:38:49', '2021-09-06 15:43:04'),
(76, 60, 2, '#', '2021-09-05 15:38:49', '2021-09-06 15:43:04'),
(77, 60, 3, '#', '2021-09-05 15:38:49', '2021-09-06 15:43:04'),
(78, 60, 4, '#', '2021-09-05 15:38:49', '2021-09-06 15:43:04'),
(79, 61, 1, '#', '2021-09-05 15:38:49', '2021-09-06 15:43:04'),
(80, 61, 2, '#', '2021-09-05 15:38:49', '2021-09-06 15:43:04'),
(81, 61, 3, '#', '2021-09-05 15:38:49', '2021-09-06 15:43:04'),
(82, 61, 4, '#', '2021-09-05 15:38:49', '2021-09-06 15:43:04'),
(83, 62, 2, '#', '2021-09-05 15:38:49', '2021-09-06 15:43:04'),
(84, 62, 3, '#', '2021-09-05 15:38:49', '2021-09-06 15:43:04'),
(85, 62, 4, '#', '2021-09-05 15:38:49', '2021-09-06 15:43:04'),
(86, 63, 2, '#', '2021-09-05 15:38:49', '2021-09-06 15:43:04'),
(87, 63, 3, '#', '2021-09-05 15:38:49', '2021-09-06 15:43:04'),
(88, 63, 4, '#', '2021-09-05 15:38:49', '2021-09-06 15:43:04'),
(89, 64, 2, '#', '2021-09-05 15:38:49', '2021-09-06 15:43:04'),
(90, 64, 3, '#', '2021-09-05 15:38:49', '2021-09-06 15:43:04'),
(91, 64, 4, '#', '2021-09-05 15:38:49', '2021-09-06 15:43:04');

-- --------------------------------------------------------

--
-- Table structure for table `projects`
--

CREATE TABLE `projects` (
  `Id` int NOT NULL,
  `TypeId` int NOT NULL,
  `Title` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Description` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedAt` datetime NOT NULL,
  `UpdatedAt` datetime NOT NULL,
  `ToolsUsed` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Thumbnail` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `projects`
--

INSERT INTO `projects` (`Id`, `TypeId`, `Title`, `Description`, `CreatedAt`, `UpdatedAt`, `ToolsUsed`, `Thumbnail`) VALUES
(60, 3, 'Portofolio', 'Our Startup Portofolio', '2021-09-05 15:38:49', '2021-09-06 15:43:04', 'CSharp-ASPNETCOREMVC-HTML-CSS-JS', 'Images/Projects\\3cb828c9-ec93-45cf-8edd-c82a60825153.JPG'),
(61, 3, 'Portofolio', 'Our Startup Portofolio', '2021-09-05 15:38:49', '2021-09-06 15:43:04', 'CSharp-ASPNETCOREMVC-HTML-CSS-JS', 'Images/Projects\\3cb828c9-ec93-45cf-8edd-c82a60825153.JPG'),
(62, 3, 'Portofolio', 'Our Startup Portofolio', '2021-09-05 15:38:49', '2021-09-06 15:43:04', 'CSharp-ASPNETCOREMVC-HTML-CSS-JS', 'Images/Projects\\3cb828c9-ec93-45cf-8edd-c82a60825153.JPG'),
(63, 3, 'Portofolio', 'Our Startup Portofolio', '2021-09-05 15:38:49', '2021-09-06 15:43:04', 'CSharp-ASPNETCOREMVC-HTML-CSS-JS', 'Images/Projects\\3cb828c9-ec93-45cf-8edd-c82a60825153.JPG'),
(64, 3, 'Portofolio', 'Our Startup Portofolio', '2021-09-05 15:38:49', '2021-09-06 15:43:04', 'CSharp-ASPNETCOREMVC-HTML-CSS-JS', 'Images/Projects\\3cb828c9-ec93-45cf-8edd-c82a60825153.JPG');

-- --------------------------------------------------------

--
-- Table structure for table `projecttypes`
--

CREATE TABLE `projecttypes` (
  `Id` int NOT NULL,
  `ProjectType` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedAt` datetime NOT NULL,
  `UpdatedAt` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `projecttypes`
--

INSERT INTO `projecttypes` (`Id`, `ProjectType`, `CreatedAt`, `UpdatedAt`) VALUES
(1, 'Desktop Application', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(2, 'Mobile Application', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(3, 'Web Application', '2021-08-23 19:15:22', '2021-08-23 19:15:22');

-- --------------------------------------------------------

--
-- Table structure for table `requestedservices`
--

CREATE TABLE `requestedservices` (
  `Id` int NOT NULL,
  `ServiceId` int NOT NULL,
  `ContactId` int NOT NULL,
  `CreatedAt` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000',
  `UpdatedAt` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `requestedservices`
--

INSERT INTO `requestedservices` (`Id`, `ServiceId`, `ContactId`, `CreatedAt`, `UpdatedAt`) VALUES
(1, 1, 51, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(2, 2, 51, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(3, 1, 52, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(4, 2, 52, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(5, 1, 53, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(6, 2, 53, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(7, 1, 54, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(8, 1, 55, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(9, 1, 56, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(10, 2, 56, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(11, 1, 57, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(12, 2, 57, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(13, 1, 58, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(14, 2, 58, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(15, 1, 59, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(16, 2, 59, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(17, 1, 60, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(18, 2, 60, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(19, 1, 61, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(20, 2, 61, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(21, 3, 62, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000');

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

CREATE TABLE `services` (
  `Id` int NOT NULL,
  `ServiceName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ServiceDescription` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ServiceImage` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedAt` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000',
  `UpdatedAt` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `services`
--

INSERT INTO `services` (`Id`, `ServiceName`, `ServiceDescription`, `ServiceImage`, `CreatedAt`, `UpdatedAt`) VALUES
(1, 'Web Application Service', 'A libero quia qui dolorum iure voluptas illo ut. Distinctio voluptas temporibus illum molestiae earum. Voluptatem fugiat ea quaerat qui illum voluptatibus natus. Labore consectetur sunt saepe. Ea distinctio est in dicta sit sequi molestiae non consequatur. Velit et repellendus a.', 'Images/Services\\4f29b64f-bcf8-4740-83b5-a705e08b02da.jpg', '0001-01-01 00:00:00.000000', '2021-09-05 14:03:45.578370'),
(2, 'Desktop Application Service', 'A libero quia qui dolorum iure voluptas illo ut. Distinctio voluptas temporibus illum molestiae earum. Voluptatem fugiat ea quaerat qui illum voluptatibus natus. Labore consectetur sunt saepe. Ea distinctio est in dicta sit sequi molestiae non consequatur. Velit et repellendus a.', 'Images/Services\\unnamed.jpg', '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(3, 'Mobile Application Service', 'Illum ea eaque est commodi. Quaerat nam voluptate sit quaerat in. Vel ut ea eum deserunt possimus et aperiam necessitatibus qui. Ducimus autem est est minima quaerat dolores modi commodi et. Vitae laudantium fugiat quibusdam dolor autem eius ut iste ducimus. Et illum corrupti ipsum qui totam.', 'Images/Services\\unnamed.jpg', '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(5, 'Other', 'Other services by demand', 'Images/Services\\unnamed.jpg', '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000'),
(6, 'Data Analysis', 'A libero quia qui dolorum iure voluptas illo ut. Distinctio voluptas temporibus illum molestiae earum. Voluptatem fugiat ea quaerat qui illum voluptatibus natus. Labore consectetur sunt saepe. Ea distinctio est in dicta sit sequi molestiae non consequatur. Velit et repellendus a.', 'Images/Services\\169d599c-f2f7-4feb-bd5a-1e90cbda5658.jpg', '2021-09-05 14:18:08.159428', '2021-09-05 14:18:08.159467'),
(7, 'Machine Learning', 'A libero quia qui dolorum iure voluptas illo ut. Distinctio voluptas temporibus illum molestiae earum. Voluptatem fugiat ea quaerat qui illum voluptatibus natus. Labore consectetur sunt saepe. Ea distinctio est in dicta sit sequi molestiae non consequatur. Velit et repellendus a.', 'Images/Services\\6f9fbcb6-0374-4e8f-87ab-c9ebbf42742b.jpg', '2021-09-05 14:18:33.614816', '2021-09-05 14:18:48.244526');

-- --------------------------------------------------------

--
-- Table structure for table `userlinks`
--

CREATE TABLE `userlinks` (
  `Id` int NOT NULL,
  `UserId` int NOT NULL,
  `TypeId` int NOT NULL,
  `Link` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `CreatedAt` datetime NOT NULL,
  `UpdatedAt` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `userlinks`
--

INSERT INTO `userlinks` (`Id`, `UserId`, `TypeId`, `Link`, `CreatedAt`, `UpdatedAt`) VALUES
(1, 1, 4, 'http://www.langworth.ca/catalog/page.asp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(2, 2, 3, 'http://www.oharahoeger.biz/shop/books/applet.aspx', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(3, 3, 3, 'http://www.gleason.biz/shop/books/applet.lsp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(4, 4, 2, 'http://www.buckridge.name/films/form.gem', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(5, 5, 4, 'http://www.stracke.us/reviews/form.aspx', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(6, 6, 1, 'http://www.shieldsschuster.uk/interviews/root.res', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(7, 7, 1, 'http://www.flatley.info/shop/films/form.lsp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(8, 8, 4, 'http://www.langosh.ca/shop/food/index.res', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(9, 9, 4, 'http://www.schiller.name/home/form.lsp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(10, 10, 2, 'http://www.feil.ca/reviews/root.jsp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(11, 11, 4, 'http://www.schulistlockman.uk/home/root.html', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(12, 12, 4, 'http://www.altenwerthschamberger.us/articles/resource.html', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(13, 13, 2, 'http://www.kuhnfriesen.ca/shop/food/template.lsp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(14, 14, 1, 'http://www.volkman.ca/shop/films/form.lsp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(15, 15, 4, 'http://www.leffler.com/shop/books/resource.aspx', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(16, 16, 4, 'http://www.schneider.co.uk/shop/films/template.lsp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(17, 17, 2, 'http://www.ankundingweimann.us/shop/food/root.rsx', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(18, 18, 2, 'http://www.schiller.ca/catalog/form.lsp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(19, 19, 3, 'http://www.barrows.ca/home/form.asp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(20, 20, 2, 'http://www.sawayn.us/shop/food/index.gem', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(21, 21, 2, 'http://www.kulasweimann.biz/shop/books/page.rsx', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(22, 22, 2, 'http://www.muller.uk/shop/form.gem', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(23, 23, 3, 'http://www.crooks.uk/interviews/applet.rsx', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(24, 24, 4, 'http://www.prohaska.ca/facts/applet.res', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(25, 25, 2, 'http://www.jaskolskikilback.co.uk/facts/page.htm', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(26, 26, 1, 'http://www.aufderhar.info/shop/food/page.jsp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(27, 27, 4, 'http://www.gottlieb.name/films/form.res', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(28, 28, 3, 'http://www.bode.co.uk/shop/food/template.htm', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(29, 29, 4, 'http://www.aufderhar.biz/films/root.jsp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(30, 30, 3, 'http://www.bogisichzemlak.com/reviews/index.jsp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(31, 31, 4, 'http://www.kozeyheller.co.uk/catalog/resource.htm', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(32, 32, 2, 'http://www.kleinwehner.uk/articles/applet.jsp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(33, 33, 4, 'http://www.yundtgislason.biz/reviews/root.html', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(34, 34, 2, 'http://www.adams.ca/shop/resource.jsp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(35, 35, 3, 'http://www.parker.com/articles/form.html', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(36, 36, 1, 'http://www.torphydach.uk/films/resource.jsp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(37, 37, 4, 'http://www.stromanhudson.uk/shop/root.res', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(38, 38, 2, 'http://www.corwin.uk/films/resource.res', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(39, 39, 1, 'http://www.schmitt.biz/shop/food/form.htm', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(40, 40, 3, 'http://www.klein.uk/films/index.htm', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(41, 41, 4, 'http://www.leannon.us/shop/books/resource.html', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(42, 42, 3, 'http://www.cole.us/guide/root.aspx', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(43, 43, 3, 'http://www.boyer.info/articles/template.aspx', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(44, 44, 3, 'http://www.cormier.name/shop/template.html', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(45, 45, 1, 'http://www.pollich.com/films/applet.gem', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(46, 46, 4, 'http://www.murray.com/facts/page.jsp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(47, 47, 1, 'http://www.cremin.info/shop/books/resource.lsp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(48, 48, 4, 'http://www.ward.com/shop/template.lsp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(49, 49, 4, 'http://www.faylebsack.info/shop/films/applet.aspx', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(50, 50, 2, 'http://www.priceemmerich.ca/home/resource.asp', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(62, 58, 2, 'https://github.com/kirollos-hany', '2021-08-25 09:36:52', '2021-08-25 09:36:52'),
(63, 58, 3, 'https://www.linkedin.com/in/kirollos-hany-92149b1b2/', '2021-08-25 09:36:52', '2021-08-25 09:36:52'),
(64, 58, 4, 'https://www.facebook.com/profile.php?id=100004658298305', '2021-08-25 09:36:52', '2021-08-25 09:36:52'),
(65, 59, 1, '#', '0001-01-01 00:00:00', '0001-01-01 00:00:00'),
(66, 59, 2, 'https://github.com/Abanoub98', '0001-01-01 00:00:00', '0001-01-01 00:00:00'),
(67, 59, 3, '#', '0001-01-01 00:00:00', '0001-01-01 00:00:00'),
(68, 59, 4, 'https://www.facebook.com/xXlBebolXx', '0001-01-01 00:00:00', '0001-01-01 00:00:00'),
(73, 61, 1, ' #', '0001-01-01 00:00:00', '0001-01-01 00:00:00'),
(74, 61, 2, ' #', '0001-01-01 00:00:00', '0001-01-01 00:00:00'),
(75, 61, 3, ' #', '0001-01-01 00:00:00', '0001-01-01 00:00:00'),
(76, 61, 4, ' #', '0001-01-01 00:00:00', '0001-01-01 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `userrolesinproject`
--

CREATE TABLE `userrolesinproject` (
  `Id` int NOT NULL,
  `Role` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedAt` datetime NOT NULL,
  `UpdatedAt` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `userrolesinproject`
--

INSERT INTO `userrolesinproject` (`Id`, `Role`, `CreatedAt`, `UpdatedAt`) VALUES
(1, 'BackEnd', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(2, 'FrontEnd', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(3, 'Team Leader', '2021-08-23 19:15:22', '2021-08-23 19:15:22'),
(4, 'Mobile', '2021-08-23 19:15:22', '2021-08-23 19:15:22');

-- --------------------------------------------------------

--
-- Table structure for table `usersinprojects`
--

CREATE TABLE `usersinprojects` (
  `Id` int NOT NULL,
  `UserId` int NOT NULL,
  `ProjectId` int NOT NULL,
  `RoleId` int NOT NULL,
  `CreatedAt` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000',
  `UpdatedAt` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `usersinprojects`
--

INSERT INTO `usersinprojects` (`Id`, `UserId`, `ProjectId`, `RoleId`, `CreatedAt`, `UpdatedAt`) VALUES
(71, 58, 60, 3, '2021-09-05 15:38:49.302671', '2021-09-06 15:43:03.668325'),
(72, 61, 60, 1, '2021-09-05 15:38:49.320765', '2021-09-06 15:43:03.672419'),
(73, 59, 60, 2, '2021-09-05 15:38:49.324432', '2021-09-06 15:43:03.676344'),
(74, 58, 61, 3, '2021-09-05 15:38:49.302671', '2021-09-06 15:43:03.668325'),
(75, 61, 61, 1, '2021-09-05 15:38:49.320765', '2021-09-06 15:43:03.672419'),
(76, 59, 61, 2, '2021-09-05 15:38:49.324432', '2021-09-06 15:43:03.676344'),
(77, 58, 62, 3, '2021-09-05 15:38:49.302671', '2021-09-06 15:43:03.668325'),
(78, 61, 62, 1, '2021-09-05 15:38:49.320765', '2021-09-06 15:43:03.672419'),
(79, 59, 62, 2, '2021-09-05 15:38:49.324432', '2021-09-06 15:43:03.676344'),
(80, 58, 63, 3, '2021-09-05 15:38:49.302671', '2021-09-06 15:43:03.668325'),
(81, 61, 63, 1, '2021-09-05 15:38:49.320765', '2021-09-06 15:43:03.672419'),
(82, 59, 63, 2, '2021-09-05 15:38:49.324432', '2021-09-06 15:43:03.676344'),
(83, 58, 64, 3, '2021-09-05 15:38:49.302671', '2021-09-06 15:43:03.668325'),
(84, 61, 64, 1, '2021-09-05 15:38:49.320765', '2021-09-06 15:43:03.672419'),
(85, 59, 64, 2, '2021-09-05 15:38:49.324432', '2021-09-06 15:43:03.676344');

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20210822143603_ResettingDbAddIdentity', '5.0.9'),
('20210823171523_AddedSpecializationToUser', '5.0.9'),
('20210831071228_AddedTimeStampsForSomeModels', '5.0.9'),
('20210831102314_EditedRelationProjectTools', '5.0.9'),
('20210905125450_RemovedImageTypes', '5.0.9'),
('20210905141130_AddedIconClassForLinks', '5.0.9');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Indexes for table `aspnetroles`
--
ALTER TABLE `aspnetroles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Indexes for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Indexes for table `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Indexes for table `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Indexes for table `aspnetusers`
--
ALTER TABLE `aspnetusers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Indexes for table `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Indexes for table `contacts`
--
ALTER TABLE `contacts`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `StatusId` (`StatusId`);

--
-- Indexes for table `contactstatuses`
--
ALTER TABLE `contactstatuses`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `Status` (`Status`);

--
-- Indexes for table `linktypes`
--
ALTER TABLE `linktypes`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `LinkType` (`LinkType`);

--
-- Indexes for table `projectfeedbacks`
--
ALTER TABLE `projectfeedbacks`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `ProjectId` (`ProjectId`);

--
-- Indexes for table `projectimages`
--
ALTER TABLE `projectimages`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `ProjectId1` (`ProjectId`);

--
-- Indexes for table `projectlinks`
--
ALTER TABLE `projectlinks`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `ProjectId2` (`ProjectId`),
  ADD KEY `TypeId1` (`TypeId`);

--
-- Indexes for table `projects`
--
ALTER TABLE `projects`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `TypeId` (`TypeId`);

--
-- Indexes for table `projecttypes`
--
ALTER TABLE `projecttypes`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `ProjectType` (`ProjectType`);

--
-- Indexes for table `requestedservices`
--
ALTER TABLE `requestedservices`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_RequestedServices_ContactId` (`ContactId`),
  ADD KEY `IX_RequestedServices_ServiceId` (`ServiceId`);

--
-- Indexes for table `services`
--
ALTER TABLE `services`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `userlinks`
--
ALTER TABLE `userlinks`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `TypeId2` (`TypeId`),
  ADD KEY `UserId` (`UserId`);

--
-- Indexes for table `userrolesinproject`
--
ALTER TABLE `userrolesinproject`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `usersinprojects`
--
ALTER TABLE `usersinprojects`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `ProjectId3` (`ProjectId`),
  ADD KEY `RoleId` (`RoleId`),
  ADD KEY `UserId1` (`UserId`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `aspnetroles`
--
ALTER TABLE `aspnetroles`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `aspnetusers`
--
ALTER TABLE `aspnetusers`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=62;

--
-- AUTO_INCREMENT for table `contacts`
--
ALTER TABLE `contacts`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=63;

--
-- AUTO_INCREMENT for table `contactstatuses`
--
ALTER TABLE `contactstatuses`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `linktypes`
--
ALTER TABLE `linktypes`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `projectfeedbacks`
--
ALTER TABLE `projectfeedbacks`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT for table `projectimages`
--
ALTER TABLE `projectimages`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;

--
-- AUTO_INCREMENT for table `projectlinks`
--
ALTER TABLE `projectlinks`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=92;

--
-- AUTO_INCREMENT for table `projects`
--
ALTER TABLE `projects`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=65;

--
-- AUTO_INCREMENT for table `projecttypes`
--
ALTER TABLE `projecttypes`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `requestedservices`
--
ALTER TABLE `requestedservices`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `services`
--
ALTER TABLE `services`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `userlinks`
--
ALTER TABLE `userlinks`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=77;

--
-- AUTO_INCREMENT for table `userrolesinproject`
--
ALTER TABLE `userrolesinproject`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `usersinprojects`
--
ALTER TABLE `usersinprojects`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=86;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `contacts`
--
ALTER TABLE `contacts`
  ADD CONSTRAINT `contacts_ibfk_1` FOREIGN KEY (`StatusId`) REFERENCES `contactstatuses` (`Id`);

--
-- Constraints for table `projectfeedbacks`
--
ALTER TABLE `projectfeedbacks`
  ADD CONSTRAINT `projectfeedbacks_ibfk_1` FOREIGN KEY (`ProjectId`) REFERENCES `projects` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `projectimages`
--
ALTER TABLE `projectimages`
  ADD CONSTRAINT `projectimages_ibfk_1` FOREIGN KEY (`ProjectId`) REFERENCES `projects` (`Id`) ON DELETE RESTRICT;

--
-- Constraints for table `projectlinks`
--
ALTER TABLE `projectlinks`
  ADD CONSTRAINT `projectlinks_ibfk_1` FOREIGN KEY (`ProjectId`) REFERENCES `projects` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `projectlinks_ibfk_2` FOREIGN KEY (`TypeId`) REFERENCES `linktypes` (`Id`) ON DELETE RESTRICT;

--
-- Constraints for table `projects`
--
ALTER TABLE `projects`
  ADD CONSTRAINT `projects_ibfk_1` FOREIGN KEY (`TypeId`) REFERENCES `projecttypes` (`Id`) ON DELETE RESTRICT;

--
-- Constraints for table `requestedservices`
--
ALTER TABLE `requestedservices`
  ADD CONSTRAINT `FK_RequestedServices_contacts_ContactId` FOREIGN KEY (`ContactId`) REFERENCES `contacts` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_RequestedServices_Services_ServiceId` FOREIGN KEY (`ServiceId`) REFERENCES `services` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `userlinks`
--
ALTER TABLE `userlinks`
  ADD CONSTRAINT `userlinks_ibfk_1` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `userlinks_ibfk_2` FOREIGN KEY (`TypeId`) REFERENCES `linktypes` (`Id`) ON DELETE RESTRICT;

--
-- Constraints for table `usersinprojects`
--
ALTER TABLE `usersinprojects`
  ADD CONSTRAINT `usersinprojects_ibfk_1` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `usersinprojects_ibfk_2` FOREIGN KEY (`ProjectId`) REFERENCES `projects` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `usersinprojects_ibfk_3` FOREIGN KEY (`RoleId`) REFERENCES `userrolesinproject` (`Id`) ON DELETE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
