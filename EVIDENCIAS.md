# Evidencias de la práctica colaborativa

## Información general

- **Equipo:** Trio Dinamico
- **Proyecto:** TeamGitPractice
- **Repositorio:** https://github.com/mateozunigapatino/TeamGitPractice
- **Integrantes: 2
- **Profesor agregado como colaborador: Orlando Lopez

## Trazabilidad por estudiante

| Estudiante | Rama personal | Commit desde consola | Commit desde Visual Studio | Pull Request | Reviewer |
|---|---|---|---|---|---|
| Mateo Zúñiga Patiño | `mateo-zuniga` | `9bfaf80` - Status inicial | `2ad8634` - Extensión de Status | [PR #1](https://github.com/mateozunigapatino/TeamGitPractice/pull/1) | Carolina Pineda Ramírez |
| Carolina Pineda Ramírez | `carolina-pineda` | `eb3c846` - Members inicial | `79883fc` - Extensión de Members | [PR #2](https://github.com/mateozunigapatino/TeamGitPractice/pull/2) | Mateo Zúñiga Patiño |

## Commits adicionales por funcionalidad

| Funcionalidad | Responsable | Primer commit | Segundo commit |
|---|---|---|---|
| Status | Mateo | `9bfaf80` | `2ad8634` |
| Members | Carolina | `eb3c846` | `79883fc` |
| Health | Carolina | `5b90c40` | `78c1a13` |
| Version | Mateo | `194fa89` | `a5a9aa8` |
| Info | Mateo | `be9b079` | `180dae4` |

## Pull Requests

| PR | Autor | Contenido | Reviewer |
|---|---|---|---|
| [#1](https://github.com/mateozunigapatino/TeamGitPractice/pull/1) | Mateo | StatusController | Carolina |
| [#2](https://github.com/mateozunigapatino/TeamGitPractice/pull/2) | Carolina | MembersController y HealthController | Mateo |
| [#3](https://github.com/mateozunigapatino/TeamGitPractice/pull/3) | Carolina | Cambio inicial de TeamMessage | Mateo |
| [#4](https://github.com/mateozunigapatino/TeamGitPractice/pull/4) | Mateo | VersionController, InfoController y resolución del conflicto | Carolina |

## Conflicto de integración

El conflicto se produjo porque ambos integrantes modificaron la misma línea de `TeamMessage.txt` desde sus ramas personales.

- **Versión de Mateo:** `Estado del proyecto: en validación.`
- **Versión de Carolina:** `Estado del proyecto: preparado para entrega.`
- **Resultado acordado:** `Estado del proyecto: preparado para entrega y en validación.`

- **Pull Request de resolución:** [PR #4](https://github.com/mateozunigapatino/TeamGitPractice/pull/4)
- **Commit de resolución:** `c61b5a0` - `fix: resolve team message conflict`

## Recuperación de cambios

### git restore

Carolina realizó una modificación temporal en `README.md` y utilizó `git restore README.md` para descartarla antes de crear un commit.

### git restore --staged

Carolina agregó temporalmente `README.md` al área de staging. Posteriormente utilizó `git restore --staged README.md` para retirarlo del staging sin eliminar inicialmente la modificación del archivo. Finalmente descartó el cambio con `git restore README.md`.

### git revert

Mateo creó la rama auxiliar `mateo-zuniga-revert`, la cual no fue integrada a `main`.

- **Commit temporal:** `46b1da0` - `test: add temporary note`
- **Commit generado por revert:** `82e4d4f` - `Revert "test: add temporary note"`

El historial conserva ambos commits, aunque `TemporaryNote.txt` no está presente en el estado final de la rama.

