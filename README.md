# TeamGitPractice

Práctica 1: trabajo colaborativo con Git, GitHub y Visual Studio Community 2026.

## Nombre del equipo

Trio Dinámico

## Descripción

Práctica colaborativa para aplicar un flujo de trabajo con Git, GitHub y Visual Studio Community 2026 sobre un proyecto ASP.NET Core Web API.
Este equipo es de 3 integrantes pero uno de ellos tuvo una calamidad por lo que no puede realizar esta actividad.
Por esta razón, cada estudiante será responsable de una o más funcionalidades, conservando los cinco controladores y los cinco Pull Requests solicitados.
Cada funcionalidad será desarrollada en la rama personal de su responsable e integrada a `main` mediante Pull Request, revisión, aprobación y merge.

## Integrantes

| Integrante | Nombre completo | Usuario de GitHub | Rama personal |
|---|---|---|---|
| 1 | Mateo Zúñiga Patiño | mateozunigapatino | mateo-zuniga |
| 2 | Carolina Pineda Ramírez | carolinapinedarr-sys | carolina-pineda |

## Distribución de funcionalidades

| Pull Request | Responsable | Controlador |
|---|---|---|
| PR 1 | Mateo Zúñiga Patiño | `StatusController.cs` |
| PR 2 | Carolina Pineda Ramírez | `MembersController.cs` |
| PR 3 | Mateo Zúñiga Patiño | `VersionController.cs` |
| PR 4 | Carolina Pineda Ramírez | `HealthController.cs` |
| PR 5 | Mateo Zúñiga Patiño | `InfoController.cs` |

## Requisitos

- .NET 10.0 SDK.
- Visual Studio Community 2026 o un editor compatible.
- Git.
- Acceso al repositorio de GitHub.

## Instrucciones para ejecutar la API

1. Clonar el repositorio:

   ```bash
   git clone https://github.com/mateozunigapatino/TeamGitPractice.git
   ```

2. Entrar en la carpeta del proyecto:

   ```bash
   cd TeamGitPractice
   ```

3. Restaurar las dependencias:

   ```bash
   dotnet restore
   ```

4. Ejecutar la API:

   ```bash
   dotnet run
   ```

5. Consultar en la terminal la dirección local asignada a la API, por ejemplo:

   ```text
   http://localhost:5094
   ```

6. Para detener la API, presionar:

   ```text
   Ctrl + C
   ```

## Endpoints del equipo

| Método | Endpoint | Responsable | Descripción |
|---|---|---|---|
| GET | `/api/status` | Mateo | Consulta el estado de la API. |
| GET | `/api/status/team` | Mateo | Consulta el estado del equipo. |
| GET | `/api/members` | Carolina | Muestra los integrantes del equipo. |
| GET | `/api/members/count` | Carolina | Muestra la cantidad de integrantes. |
| GET | `/api/version` | Mateo | Muestra la versión de la aplicación. |
| GET | `/api/version/platform` | Mateo | Muestra la plataforma utilizada. |
| GET | `/api/health` | Carolina | Consulta el estado de salud de la API. |
| GET | `/api/health/time` | Carolina | Muestra la hora UTC del servidor. |
| GET | `/api/info` | Mateo | Muestra información general del proyecto. |
| GET | `/api/info/tools` | Mateo | Muestra las herramientas utilizadas. |