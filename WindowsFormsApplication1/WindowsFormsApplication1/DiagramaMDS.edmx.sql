
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/31/2017 23:02:27
-- Generated from EDMX file: C:\Users\sawak\Desktop\Ipleiria\2º Semestre\Metodologias de Desenvolvimento de Software\ProjetoMDS\WindowsFormsApplication1\WindowsFormsApplication1\DiagramaMDS.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Basemds];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ConsultaSet'
CREATE TABLE [dbo].[ConsultaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nome_paciente] nvarchar(max)  NOT NULL,
    [dia] datetime  NOT NULL,
    [hora] datetime  NOT NULL,
    [especialidade] nvarchar(max)  NOT NULL,
    [MedicoId] int  NOT NULL
);
GO

-- Creating table 'MedicoSet'
CREATE TABLE [dbo].[MedicoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL,
    [especialidade] nvarchar(max)  NOT NULL,
    [nif] int  NOT NULL,
    [hora_inicio] datetime  NOT NULL,
    [hora_fim] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [PK_ConsultaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MedicoSet'
ALTER TABLE [dbo].[MedicoSet]
ADD CONSTRAINT [PK_MedicoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MedicoId] in table 'ConsultaSet'
ALTER TABLE [dbo].[ConsultaSet]
ADD CONSTRAINT [FK_MedicoConsulta]
    FOREIGN KEY ([MedicoId])
    REFERENCES [dbo].[MedicoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoConsulta'
CREATE INDEX [IX_FK_MedicoConsulta]
ON [dbo].[ConsultaSet]
    ([MedicoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------