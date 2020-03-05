<p align="center"><img src="https://3.bp.blogspot.com/-mxF__jCVkCU/XefJCxxy9WI/AAAAAAAAXyg/AvVFyFT0JAEquOWki4j1sw4hu_RlBZDQwCLcBGAsYHQ/s1600/download-latest-dotnet-core-min.jpg"></p>

## Konaba projetu

Projetu ne hanesan passatempo hodi atualiza kunhesimento iha área .Net Framework ba .Net Core. Atualmente .Net Core iha ninia versaun mais recente mak .Net Core 3.1

Projeto simples ne tenta atu simula registos ba evento ruma, tal como conferencias ou seminários

- Web Template nebe usa maka ida nebe iha página ida ne https://bootstrapmade.com/demo/TheEvent/


## Requisitos
Basta iha Visual Studio 2019 (mai ho kedas .net 3.1) e sqlserver express ou bele mos mysql server hodi executa projeto ne.

NB: Precisa atualiza ficheiro appsetings.json e nlog.config tuir idak2 nia connectionstring e "log file path"

## Execução
Iha Package Manager Console
-- Executa comando "Update-Database -Context ApplicationDbContext" hodi cria tabelas associados ba Asp.Net Core Identity. 
Certifica katak projeto EventConference.Web selecionado
-- Seleciona projeto EventConference.Entities iha Package Manager Console e executa comando "Update-Database -Context RepositoryContext" hodi cria tabelas associadas ba evento

NB: Precisa melhoramento buat barak (devagar se vai ao longe)