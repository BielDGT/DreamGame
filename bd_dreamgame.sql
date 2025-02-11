-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 11/02/2025 às 15:41
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bd_dreamgame`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_games`
--

CREATE TABLE `tb_games` (
  `Id` int(11) NOT NULL,
  `Titulo` varchar(255) NOT NULL,
  `Avaliação` varchar(2) NOT NULL,
  `Tamanho` varchar(255) NOT NULL,
  `Descrição` varchar(255) NOT NULL,
  `Valor` varchar(8) NOT NULL,
  `Desenvolvedor` varchar(255) NOT NULL,
  `Genero` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_games`
--

INSERT INTO `tb_games` (`Id`, `Titulo`, `Avaliação`, `Tamanho`, `Descrição`, `Valor`, `Desenvolvedor`, `Genero`) VALUES
(1, 'teste', '50', '100', 'amazing', 'R$1.000,', 'Testeter', 'Ação'),
(2, 'teste2', '20', '10010000000000', 'engraçado', 'R$1.000,', 'testedor', 'Comedia'),
(3, 'doom', '3', '  1.20Gb', 'sdfsdfsdf', 'R$ .  1,', 'ksdflksdkljf', 'Fantasia');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `tb_games`
--
ALTER TABLE `tb_games`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_games`
--
ALTER TABLE `tb_games`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
