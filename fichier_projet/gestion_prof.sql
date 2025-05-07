-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 07 mai 2025 à 07:35
-- Version du serveur : 8.3.0
-- Version de PHP : 8.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestion_prof`
--

-- --------------------------------------------------------

--
-- Structure de la table `classes`
--

DROP TABLE IF EXISTS `classes`;
CREATE TABLE IF NOT EXISTS `classes` (
  `numClasse` int NOT NULL AUTO_INCREMENT,
  `nomClasse` varchar(15) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `nbEleve` int DEFAULT NULL,
  PRIMARY KEY (`numClasse`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `classes`
--

INSERT INTO `classes` (`numClasse`, `nomClasse`, `nbEleve`) VALUES
(1, '1TSIO', 30),
(2, '2TSSL', 15),
(3, '2TSSI', 15);

-- --------------------------------------------------------

--
-- Structure de la table `connexion`
--

DROP TABLE IF EXISTS `connexion`;
CREATE TABLE IF NOT EXISTS `connexion` (
  `numConnexion` int NOT NULL AUTO_INCREMENT,
  `login` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `mdp` varchar(20) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `numProf` int NOT NULL,
  PRIMARY KEY (`numConnexion`),
  KEY `numProf` (`numProf`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `connexion`
--

INSERT INTO `connexion` (`numConnexion`, `login`, `mdp`, `numProf`) VALUES
(1, 'admin', 'root', 1);

-- --------------------------------------------------------

--
-- Structure de la table `enseigner`
--

DROP TABLE IF EXISTS `enseigner`;
CREATE TABLE IF NOT EXISTS `enseigner` (
  `numProf` int NOT NULL,
  `numMat` int NOT NULL,
  PRIMARY KEY (`numProf`,`numMat`),
  KEY `numMat` (`numMat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `enseigner`
--

INSERT INTO `enseigner` (`numProf`, `numMat`) VALUES
(9, 1),
(11, 1),
(3, 2),
(12, 2),
(2, 3),
(4, 4),
(10, 4),
(1, 5),
(7, 5),
(8, 5),
(5, 6),
(6, 6),
(7, 7),
(1, 8),
(7, 8),
(3, 9),
(1, 10),
(1, 11);

-- --------------------------------------------------------

--
-- Structure de la table `entreprises`
--

DROP TABLE IF EXISTS `entreprises`;
CREATE TABLE IF NOT EXISTS `entreprises` (
  `numEntrerprise` int NOT NULL AUTO_INCREMENT,
  `nomEntreprise` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `telEntreprise` varchar(14) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `mailEntreprise` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `adresseEntreprise` varchar(150) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`numEntrerprise`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `entreprises`
--

INSERT INTO `entreprises` (`numEntrerprise`, `nomEntreprise`, `telEntreprise`, `mailEntreprise`, `adresseEntreprise`) VALUES
(1, 'Ardemis parteners', '04 91 00 10 01', 'contact@ardemispartners.com', '21 rue de Cassis, 13008 Marseille'),
(2, 'Artonik', '04 91 37 70 76', 'contact@artonik.com', '164 Cours Lieutaud, 13006 Marseille'),
(3, 'AXYN Robotique', '09 50 97 50 61', 'contact@axynrobotique.com', '1480 Avenue d\'Armenie, 13120 Gardanne'),
(4, 'BTP Tech', '06 78 31 31 08', 'contact@btptech.com', '1 chemin de la colline st Joseph 13009, Marseille'),
(5, 'Conseil régional', '04 91 57 50 57', 'glorente@maregionsud.fr', '27 PLACE JULES GUESDE 13481, Marseille'),
(6, 'Coorty', '04 92 45 78 23', 'contact@coorty.com', '21 rue marc Donadille, 13013 Marseille'),
(7, 'Digiteck', '04 42 06 72 66', 'contact@digiteck.com', '95 Bd de l\'Europe, 13127 Vitrolles'),
(8, 'Ebénisterie EMDP', '04 92 67 34 12', 'contact@ebinisterie-emdp.fr', '10 rue de la conception 13004, Marseille'),
(9, 'Ecodaire Marseille', '07 66 42 43 17', 'contact@ecodairemarseille.com', '116 BD de la pomme, 13011 Marseille'),
(10, 'Fiducial Informatique', '04 37 64 71 00', 'contact@fiducialinformatique.com', '30 rue Sergent Michel Berthet, 69009 Lyon'),
(11, 'GCZDesign', '06 36 48 68 68', 'contact@gczdesign.com', '6 rue Capazza, 13004 Marseille'),
(12, 'Hermes informatique', '04 65 01 04 60', 'contact@hermesinformatique.com', '64 AVENUE HAIFA 13008, Marseille'),
(13, 'Hopital de la Conception', '04 92 43 21 56', 'contact@hopitaldelaconception.com', '147 Bd Baille, 13005 Marseille'),
(14, 'Hopital de la Timone', '04 92 66 89 45', 'contact@hopitaldelatimone.com', '265 RUE SAINT PIERRE 13005, Marseille'),
(15, 'Hôtel de ville', '04 42 74 93 15', 'services@hoteldeville.com', 'Place Jean Moulin, 13138 Berre-l\'étang '),
(16, 'IHU Méditerranée', '04 92 66 89 45', 'contact@ihumediterranee.com', '19-21 Bd Jean Moulin, 13005 Marseille'),
(17, 'Kalune digital service', '04 92 57 34 78', 'contact@kalune.fr', '24 Av du Prado, 13006 Marseille'),
(18, 'Marin pompier de marseille', '04 92 63 12 59', 'contact@marinspompiersdemarseille.com', '139 Bd de Plombières, 13003 Marseille'),
(19, 'Ministère de la culture', '04 92 50 47 31', 'service@ministeredelaculture.com', '182 Rue saint honoré ,75001 Paris'),
(20, 'Reliance RH', '04 69 44 19 99', 'contact@reliancerh.com', '41 Rue de village 13006, Marseille'),
(21, 'Ville de marseille', '04 92 41 68 79', 'services.publics@villedemarseille.fr', 'Pl. Villeneuve-Bargemon, 13002 Marseille'),
(22, 'Wu tao wang xue long', '04 92 61 35 88', 'contact@wutaowangxuelong.com', '613 Avenue du garlaban, 13400 Marseille');

-- --------------------------------------------------------

--
-- Structure de la table `etudiants`
--

DROP TABLE IF EXISTS `etudiants`;
CREATE TABLE IF NOT EXISTS `etudiants` (
  `numEtudiant` int NOT NULL AUTO_INCREMENT,
  `nomEtudiant` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `prenomEtudiant` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `mailEtudiant` varchar(200) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `telEtudiant` varchar(14) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `numProf` int DEFAULT NULL,
  `numClasse` int DEFAULT NULL,
  PRIMARY KEY (`numEtudiant`),
  KEY `numProf` (`numProf`),
  KEY `numClasse` (`numClasse`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `etudiants`
--

INSERT INTO `etudiants` (`numEtudiant`, `nomEtudiant`, `prenomEtudiant`, `mailEtudiant`, `telEtudiant`, `numProf`, `numClasse`) VALUES
(3, 'ALI MOHAMED', 'Nasra', 'alimohamed.nasraa@gmail.com', '06 45 23 87 12', 7, 2),
(4, 'AZRI', 'Nour El Imane ', 'azrinourelimane@gmail.com', '07 56 39 24 56', 7, 2),
(5, 'BEKHTAOUI', 'Nadir Safir', 'nadirbekhtaoui13@gmail.com', '06 72 11 89 34', 7, 2),
(6, 'BELHOCINE ', 'Rayan ', 'rayanbelho@hotmail.com', '07 83 67 21 09', 7, 2),
(7, 'BENAMAR', 'Tadj Eddine', 'tadjbenamar@gmail.com', '06 88 54 32 18', 7, 2),
(8, 'BOUABBOUNE', 'Aymen', 'aymenbouabboume@gmail.com', '07 61 27 45 90', 7, 2),
(9, 'GOUADJELIA', 'Amir Foued', 'amirgouadjelia97@gmail.com', '06 29 74 63 85', 7, 2),
(10, 'KAHLA', 'Iliasse', 'kahlailiasse@gmail.com', '07 38 50 12 67', 7, 2),
(11, 'IDOUDI', 'Sayf-Eddine', 'sdoufi25@gmail.com', '06 95 48 26 73', 7, 2),
(12, 'KINEIDER', 'Marc Ange', 'kineider.marc@laposte.net', '07 82 61 55 98', 7, 2),
(13, 'LEAL DIAS SEMEDO', 'Sara', 'slealsemedo@gmail.com', '06 53 79 41 20', 7, 2),
(14, 'MUNCH ADAMOU', 'Enzo', 'enzomunchadamou@gmail.com', '07 64 93 80 11', 7, 2),
(15, 'MERHAB', 'Adam', 'adam.merhab@hotmail.fr', '06 17 38 60 54', 7, 2),
(16, 'ABDELLI', 'Elyas', 'elyas.abdelli@gmail.com', '07 25 46 72 39', 6, 3),
(17, 'ALLARD', 'Eden', 'eden.allard@gmail.com', '06 62 93 51 80', 6, 3),
(18, 'ANOTHO EDOWIZA', 'Reynald', 'reynald.anotho.edowiza@gmail.com', '07 49 82 63 21', 6, 3),
(19, 'ATTOUMANI', 'El-Aziz', 'elaziz.attoumanii@gmail.com', '06 81 58 24 12', 6, 3),
(20, 'BUGNOLI', 'Alexandre', 'a.bugnoli@gmail.com', '07 70 35 67 82', 6, 3),
(21, 'GIRARD', 'Emilie ', 'emiliegirarddefr@gmail.com', '06 44 79 58 31', 6, 3),
(22, 'KOUAIDIA', 'Adam ', 'kouaidia.adam@gmail.com', '07 96 72 34 59', 6, 3),
(23, 'LAKHDAR EZZINE ', 'Mohamed Adel ', 'abdl.lkd13@gmail.com', '06 39 81 67 40', 6, 3),
(24, 'LY', 'Murray Thomas Chizaram', 'lymurraymc@gmail.com', '07 53 26 58 14', 6, 3),
(25, 'MALVY', 'Valentin Gilbert Philippe', 'valentin.malvy@hotmail.fr', '06 75 48 39 23', 6, 3),
(26, 'MEBAOUDJ', 'Nawfel', 'nawfel.mebaoudj@hotmail.fr', '07 61 19 84 51', 6, 3),
(27, 'POTARD', 'Joan Corto Jean', 'joan.potard@gmail.com', '06 56 30 72 64', 6, 3),
(28, 'WELFRINGER', 'Dorian', 'd.welfringer@gmail.com', '06 24 65 87 13', 6, 3),
(29, 'ALI', 'Moudjahidi', 'moudjahidi.ali@gmail.com', '07 80 52 34 97', 1, 1),
(30, 'AZZI', 'Akram', 'a.azzi@gmail.com', '06 59 73 42 08', 1, 1),
(31, 'BANDIERA', 'Gianni', 'gianni.bandiera.pro@hotmail.fr', '07 28 61 48 25', 1, 1),
(32, 'BOURI', 'Houssam', 'h.bouri@gmail.com', '06 91 56 34 72', 1, 1),
(33, 'CORDOVANA', 'Lucas', 'lucas.cordovana123@gmail.com', '07 35 80 67 14', 1, 1),
(34, 'COULANGE', 'Matteo', 'm.coulange@gmail.com', '06 40 77 29 61', 1, 1),
(35, 'DEBABO', 'Célia', 'celia.debabo@hotmail.fr', '07 68 53 42 09', 1, 1),
(36, 'DELPORTO', 'Lorina', 'lorina.delporto@hotmail.fr', '06 74 52 18 83', 1, 1),
(37, 'DOUCHET', 'Dylan', 'dylan.douchet@gmail.com', '07 21 46 88 54', 1, 1),
(38, 'MSA', 'Elmira', 'elmira.msa@gmail.com', '06 89 32 51 70', 1, 1),
(39, 'MADANI', 'Mouad', 'mouad.madani@gmail.com', '07 14 75 53 66', 1, 1),
(40, 'MARSEL', 'Ghozlène', 'g.marsel@gmail.com', '06 61 47 32 58', 1, 1),
(41, 'MEDMONE', 'Nadra', 'nadra.medmone@gmail.com', '07 39 60 19 81', 1, 1),
(42, 'MOKAREM', 'Mohamed Fodhel', 'm.fodhel.mokarem@gmail.com', '06 55 76 91 23', 1, 1),
(43, 'MOLLET', 'Oreyanne', 'oreyanne.mollet@gmail.com', '07 83 61 29 47', 1, 1),
(44, 'MORIOT', 'Florent', 'florent.moriot@hotmail.fr', '06 72 54 63 85', 1, 1),
(45, 'NGANDU-MUAMBA', 'Djelissa', 'djelissa.ngandu.muamba@gmail.com', '07 52 39 70 11', 1, 1),
(46, 'QUINZII', 'Valentin', 'valentin.quinzii@hotmail.fr', '06 68 42 58 96', 1, 1),
(47, 'RAINGEVAL', 'Hadrien', 'hadrien.raingeval.pro@hotmail.fr', '07 20 77 31 62', 1, 1),
(48, 'SAIDI', 'Billal', 'billal.saidi@gmail.com', '06 37 83 69 21', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `matières`
--

DROP TABLE IF EXISTS `matières`;
CREATE TABLE IF NOT EXISTS `matières` (
  `numMat` int NOT NULL AUTO_INCREMENT,
  `nomMat` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`numMat`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `matières`
--

INSERT INTO `matières` (`numMat`, `nomMat`) VALUES
(1, 'CEJM'),
(2, 'Maths'),
(3, 'Anglais'),
(4, 'CGE'),
(5, 'SLAM'),
(6, 'SISR'),
(7, 'Cybersecurite'),
(8, 'AT Pro'),
(9, 'Math Appro'),
(10, 'Certif'),
(11, 'SDSI');

-- --------------------------------------------------------

--
-- Structure de la table `professeurs`
--

DROP TABLE IF EXISTS `professeurs`;
CREATE TABLE IF NOT EXISTS `professeurs` (
  `numProf` int NOT NULL AUTO_INCREMENT,
  `nomProf` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `prenomProf` varchar(20) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `mailProf` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `telProf` varchar(14) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `nbHeures` smallint DEFAULT NULL,
  PRIMARY KEY (`numProf`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `professeurs`
--

INSERT INTO `professeurs` (`numProf`, `nomProf`, `prenomProf`, `mailProf`, `telProf`, `nbHeures`) VALUES
(1, 'BRUNO', 'Paul', 'paul.bruno@gmail.com', '06 11 22 33 44', NULL),
(2, 'CASTA', 'Joelle', 'joelle.casta.prof@gmail.com', '06 12 34 56 90', NULL),
(3, 'GILLY', 'Fabrice', 'fabrice.gilly.prof@gmail.com', '07 21 34 56 78', NULL),
(4, 'GODARD-TSAPIS', 'Helene', 'helene.godard-tsapis@gmail.com', '06 87 65 43 21', NULL),
(5, 'LEFEVRE', 'Herve', 'herve.lefevre@gmail.com', '07 12 34 56 90', NULL),
(6, 'MARKOVITCH', 'Yan', 'yan.markovitch@gmail.com', '06 45 67 89 01', NULL),
(7, 'MICHAUD', 'Christian', 'christian.michaud@gmail.com', '07 23 45 67 89', NULL),
(8, 'PASTORE', 'Sebastien', 'sebastien.pastore@gmail.com', '06 54 32 10 98', NULL),
(9, 'PEDUZZI', 'Nicolas', 'nicolas.peduzzi.prof@gmail.com', '07 56 78 90 12', NULL),
(10, 'FRAYSSINHES', 'Laure', 'laure.frayssinhes.prof@gmail.com', '06 89 01 23 45', NULL),
(11, 'GARNIER', 'Marine', 'marine.garnier.prof@gmail.com', '06 34 56 78 90', NULL),
(12, 'NICOLAS', 'Julien', 'julien.nicolas@gmail.com', '07 12 34 56 78', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `stages`
--

DROP TABLE IF EXISTS `stages`;
CREATE TABLE IF NOT EXISTS `stages` (
  `numEtudiant` int NOT NULL,
  `numTuteur` int NOT NULL,
  `dateStageDebut` date DEFAULT NULL,
  `dateStageFin` date DEFAULT NULL,
  PRIMARY KEY (`numEtudiant`,`numTuteur`),
  KEY `numTuteur` (`numTuteur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `stages`
--

INSERT INTO `stages` (`numEtudiant`, `numTuteur`, `dateStageDebut`, `dateStageFin`) VALUES
(18, 13, '2024-05-21', '2024-06-28'),
(20, 13, '2024-05-21', '2024-06-28'),
(25, 13, '2024-05-21', '2024-06-28'),
(28, 13, '2024-05-21', '2024-06-28');

-- --------------------------------------------------------

--
-- Structure de la table `tuteurs`
--

DROP TABLE IF EXISTS `tuteurs`;
CREATE TABLE IF NOT EXISTS `tuteurs` (
  `numTuteur` int NOT NULL AUTO_INCREMENT,
  `nomTuteur` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `prenomTuteur` varchar(20) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `telTuteur` varchar(14) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `mailTuteur` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_unicode_ci DEFAULT NULL,
  `numEntrerprise` int NOT NULL,
  PRIMARY KEY (`numTuteur`),
  KEY `numEntrerprise` (`numEntrerprise`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Déchargement des données de la table `tuteurs`
--

INSERT INTO `tuteurs` (`numTuteur`, `nomTuteur`, `prenomTuteur`, `telTuteur`, `mailTuteur`, `numEntrerprise`) VALUES
(1, 'PARMAKSIZIAN', 'Mathieu', '06 86 95 50 02', 'mathieu@ardemispartners.com', 1),
(2, 'COHEN-SOLAL', 'Cyrille', '06 12 65 58 44', 'ronny.cohen@artonik.com', 2),
(3, 'BENFERHAT', 'Samia', '09 50 97 50 61', 'samia.benferhat@axyn.fr', 3),
(4, 'PARANDERA', 'Julien', '06 78 31 31 08', 'j.paranderapro@gmail.com', 4),
(5, 'MUSELIER', 'Renaud', NULL, 'glorente@maregionsud.fr', 5),
(6, 'CALMETTES', 'Antoine', '04 91 25 75 75', 'co@coorty.fr', 6),
(7, 'DENDANI', 'Aymen', '05 10 18 70 18', 'ayem.dendani@digiteck.fr', 7),
(8, 'PARIZOT', NULL, NULL, 'contact@ebinisterie-emdp.fr', 8),
(9, 'BENAMAR', 'Said', '07 49 53 16 23', 'sbenamar@ecodair.org', 9),
(10, 'MAURICE', 'Benoit', '04 37 64 71 00', 'benoit.maurice@fiducial.fr', 10),
(11, 'GOCZKOWSKI', 'Alexandre', '06 36 48 68 68', 'alexandre@gczdesign.com', 11),
(12, 'RIDOLFO', 'Régis', NULL, 'regis.ridolfo@ap-hm.fr', 13),
(13, 'CARDARO', 'Celine', NULL, 'celine.cardano@ap-hm.fr', 14),
(14, 'STOUPAN', 'Didier', '06 07 40 86 81', 'dstoupan@aphm.fr', 16),
(15, 'STOUPAN', 'Didier', '06 07 40 86 81', 'dstoupan@aphm.fr', 17),
(16, 'PARIZO', 'Bruno', '06 14 69 17 32', 'contact@kalune.fr', 17),
(17, 'BARTHOLOMEY', 'Cédric', NULL, NULL, 18),
(18, 'LUZITISA', 'Amédé', NULL, 'amede.luzitisa@culture.gouv.fr', 19),
(19, 'Donneau', 'Christine', NULL, 'christine.donneau@reliance-rh.com', 20),
(20, 'MICHAUD', 'Christian', NULL, NULL, 22);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `connexion`
--
ALTER TABLE `connexion`
  ADD CONSTRAINT `numProf` FOREIGN KEY (`numProf`) REFERENCES `professeurs` (`numProf`);

--
-- Contraintes pour la table `enseigner`
--
ALTER TABLE `enseigner`
  ADD CONSTRAINT `enseigner_ibfk_1` FOREIGN KEY (`numProf`) REFERENCES `professeurs` (`numProf`),
  ADD CONSTRAINT `enseigner_ibfk_2` FOREIGN KEY (`numMat`) REFERENCES `matières` (`numMat`);

--
-- Contraintes pour la table `etudiants`
--
ALTER TABLE `etudiants`
  ADD CONSTRAINT `etudiants_ibfk_1` FOREIGN KEY (`numProf`) REFERENCES `professeurs` (`numProf`),
  ADD CONSTRAINT `etudiants_ibfk_2` FOREIGN KEY (`numClasse`) REFERENCES `classes` (`numClasse`);

--
-- Contraintes pour la table `stages`
--
ALTER TABLE `stages`
  ADD CONSTRAINT `stages_ibfk_1` FOREIGN KEY (`numEtudiant`) REFERENCES `etudiants` (`numEtudiant`),
  ADD CONSTRAINT `stages_ibfk_2` FOREIGN KEY (`numTuteur`) REFERENCES `tuteurs` (`numTuteur`);

--
-- Contraintes pour la table `tuteurs`
--
ALTER TABLE `tuteurs`
  ADD CONSTRAINT `tuteurs_ibfk_1` FOREIGN KEY (`numEntrerprise`) REFERENCES `entreprises` (`numEntrerprise`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
