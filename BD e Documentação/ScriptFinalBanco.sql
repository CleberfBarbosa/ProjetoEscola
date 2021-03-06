USE [EscolaDeFormacao]
GO
/****** Object:  Table [dbo].[Aluno]    Script Date: 30/11/2017 23:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aluno](
	[IDAluno] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[RG] [varchar](15) NOT NULL,
	[CPF] [varchar](20) NOT NULL,
	[DataNascimento] [date] NOT NULL,
	[Escolaridade] [varchar](50) NOT NULL,
	[Endereco] [varchar](100) NOT NULL,
	[IDResponsavel] [int] NULL,
	[FoneFixo] [varchar](20) NULL,
	[FoneCelular] [varchar](20) NULL,
 CONSTRAINT [PK_Aluno] PRIMARY KEY CLUSTERED 
(
	[IDAluno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AlunoCurso]    Script Date: 30/11/2017 23:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlunoCurso](
	[IDAluno] [int] NOT NULL,
	[IDCurso] [int] NOT NULL,
	[DataMatricula] [datetime] NOT NULL,
 CONSTRAINT [PK_AlunoCurso_1] PRIMARY KEY CLUSTERED 
(
	[IDAluno] ASC,
	[IDCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 30/11/2017 23:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[IDCurso] [int] IDENTITY(1,1) NOT NULL,
	[Curso] [varchar](50) NOT NULL,
	[Turma] [varchar](5) NOT NULL,
	[DiasSemana] [varchar](50) NOT NULL,
	[Horario] [time](7) NOT NULL,
	[DataInicio] [date] NOT NULL,
	[DataFim] [date] NOT NULL,
	[Ativo] [varchar](10) NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[IDCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Responsavel]    Script Date: 30/11/2017 23:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Responsavel](
	[IDResponsavel] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[RG] [varchar](15) NOT NULL,
	[CPF] [varchar](20) NOT NULL,
	[Parentesco] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Responsavel] PRIMARY KEY CLUSTERED 
(
	[IDResponsavel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Aluno]  WITH CHECK ADD  CONSTRAINT [FK_Aluno_Responsavel] FOREIGN KEY([IDResponsavel])
REFERENCES [dbo].[Responsavel] ([IDResponsavel])
GO
ALTER TABLE [dbo].[Aluno] CHECK CONSTRAINT [FK_Aluno_Responsavel]
GO
ALTER TABLE [dbo].[AlunoCurso]  WITH CHECK ADD  CONSTRAINT [FK_AlunoCurso_Aluno] FOREIGN KEY([IDAluno])
REFERENCES [dbo].[Aluno] ([IDAluno])
GO
ALTER TABLE [dbo].[AlunoCurso] CHECK CONSTRAINT [FK_AlunoCurso_Aluno]
GO
ALTER TABLE [dbo].[AlunoCurso]  WITH CHECK ADD  CONSTRAINT [FK_AlunoCurso_Curso] FOREIGN KEY([IDCurso])
REFERENCES [dbo].[Curso] ([IDCurso])
GO
ALTER TABLE [dbo].[AlunoCurso] CHECK CONSTRAINT [FK_AlunoCurso_Curso]
GO
