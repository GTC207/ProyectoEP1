# Sistema de Gestión de Trámites - Nido Estrellita de Fátima

## Descripción
Sistema de consola desarrollado en C# para administrar los trámites de los alumnos del Nido Estrellita de Fátima mediante operaciones CRUD ,  se tiliza archivos para el almacenamiento permanente de los datos y control de versiones con Git y GitHub.

## Integrantes
| Nombre | Usuario de GitHub | Módulo a cargo |
|---|---|---|
| [Franchesca Paola Cherrez Espinoza] | [Franches-upn] | [ ordenamiento con el git  y estructura de las clases ] |
| [GIANPIERO TORRES CASACHAHUA] | [GTC207] | [desarrollo del sistema de la clase gestortramites, tramites] |
| [KAREN JUDITH PAUCAR MENDIETA ] | [] | [implementacion de metodos ] |
| [LEYLA ANDREA POMA ARROYO ] | [] | [implementacion de textos binario para no perder el registro y se pueda guardar] |
| [ALEXIS MICHAEL CERCADO CRUZADO] | [] | [Ver errores en el sistema y probando el sistema para que no haya ningún error al momento de registrar a un alumno] |

## Tecnologías
- C# (aplicación de consola, .NET Framework)
- Visual Studio
- Serialización de archivos
- Git y GitHub

## Funcionalidades
- [Registrar y buscar los trámites del alumno y profesor]
- [Mostrar trámites registrados]
- [Buscar por código de alumno]
- [Editar trámites]
- [Eliminar trámites]
- [Guardar y leer datos desde archivo]

## Estructura del proyecto
```
Proyecto10-main/
├── modelo/
│   └── tramites.cs   // Datos del alumno y del trámite
├── servicio/
│   └── gestortramites.cs  //Lógica CRUD
├── archivos/
│   └── ArchivoTramites.cs   //Guardado y lectura en archivo
├── Program.cs               //Menú principal
└── App.config
```

## Instalación y ejecución
1. Clonar el repositorio:
   `git clone https://github.com/GTC207/ProyectoEP1.git`
2. Abrir el archivo de solución con Visual Studio.
3. Compilar con Ctrl + Shift + B.
4. Ejecutar con F5.

## Evidencias
Estructura inicial del proyecto
<img width="919" height="352" alt="image" src="https://github.com/user-attachments/assets/be4850af-fa04-41bf-b9c3-c2ace29c4d24" />
Clase tramites implementada
gestortramites
<img width="1361" height="607" alt="image" src="https://github.com/user-attachments/assets/f60a6490-e2d9-494b-91bc-dc26edee5a7f" />
Agregue ArchivoTramites
<img width="1355" height="624" alt="image" src="https://github.com/user-attachments/assets/d0ded8c6-0c29-4c48-942a-dab23b268808" />
Desarrollo del codigo registrar alumno:
<img width="943" height="474" alt="image" src="https://github.com/user-attachments/assets/ee8c0a0c-4171-4327-bd5a-3914d8c215c1" />
<img width="958" height="481" alt="image" src="https://github.com/user-attachments/assets/caf5e0ba-6094-42a9-942b-ef9e10e4cc46" />
código del profesor y tutor: 
<img width="958" height="481" alt="image" src="https://github.com/user-attachments/assets/cbcc52f0-c992-4a6e-9487-1ce423ae851b" />
 para mostrar el registro
 <img width="965" height="510" alt="image" src="https://github.com/user-attachments/assets/32d5e436-7e41-40c3-a007-7d6ae24fb03e" />

implementación de poder modificar el registro
<img width="963" height="506" alt="image" src="https://github.com/user-attachments/assets/af66e61f-7005-42c1-930a-60cb6f6c5678" />
Guardar en archivo de texto
implementación de poder eleiminar el registro:

<img width="980" height="520" alt="image" src="https://github.com/user-attachments/assets/13cc3af4-b862-4f2a-b141-dd56742bae2e" />


implementacion de buscar por codigo, nombre,apellido,profesor, nota:

<img width="981" height="506" alt="image" src="https://github.com/user-attachments/assets/07d35395-6e81-4a09-9680-6eb5fb316f4f" />


<img width="962" height="512" alt="image" src="https://github.com/user-attachments/assets/a68f90bc-c68c-4c54-957f-ea323b1ab064" />


<img width="963" height="509" alt="image" src="https://github.com/user-attachments/assets/7fdf20b2-daf8-4ccb-98bf-8e4cc30390fb" />


Cargar desde archivo de texto

<img width="1123" height="464" alt="image" src="https://github.com/user-attachments/assets/7510ec86-7404-42b6-b780-d24f5499ae21" />

Guardar en archivo binario

<img width="587" height="367" alt="image" src="https://github.com/user-attachments/assets/a73228a4-6e77-4705-be2f-9af4080fa23e" />

Cargar desde archivo binario

<img width="803" height="294" alt="image" src="https://github.com/user-attachments/assets/711b0b89-6ab2-4d95-a178-e7646671323a" />

Ordenar los tramites por seccion utilizando el metodo burbuja:

<img width="958" height="500" alt="image" src="https://github.com/user-attachments/assets/2e6f4718-041c-4ca9-b5cd-f18125c84c0f" />


Ordenar los tramites por seccion utilizando el metodo Seleccion:

<img width="964" height="488" alt="image" src="https://github.com/user-attachments/assets/22093315-a201-4d90-b38a-243d4b94cb70" />


## Repositorio
https://github.com/GTC207/ProyectoEP1
