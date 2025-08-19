Frontend: Aplicación cliente con interfaz de usuario.  
Backend: Servicios y lógica de negocio.  
APIs Funcionales: Endpoints para la comunicación entre frontend y backend.  
Pruebas Unitarias: Validación de la lógica implementada.  
Docker Compose: Orquestación de los servicios para levantar el proyecto completo.


Tecnologías Utilizadas

Lenguajes: C#, JavaScript  
Contenedores: Docker & Docker Compose  
Pruebas: Unit Testing con .NET  
Gestión de dependencias: package-lock.json y nuget  
Otros: PowerShell para automatización de scripts  

---

Requisitos Previos

Antes de ejecutar el proyecto, asegúrate de tener instalado:

[Git](https://git-scm.com/)  
[Docker Desktop](https://www.docker.com/products/docker-desktop)  
[.NET 6 SDK](https://dotnet.microsoft.com/en-us/download) (si se quiere ejecutar localmente sin Docker)  


Ejecución del Proyecto

 1. Clonar el repositorio
   *bash
 git clone https://github.com/NataMB/PruebaSenior.git
cd PruebaSenior

 3. Levantar con Docker
bash
Copiar
Editar
docker-compose up --build
Esto levantará automáticamente el frontend, backend y las APIs.


 4. Acceso a la aplicación
Frontend: http://localhost:3000

Backend / API: http://localhost:5000


