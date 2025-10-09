# PostgresDataLoggerService
Lightweight ASP.NET Core (.NET 8, C# 12) Web API for logging and retrieving survey / navigation related time‑series data in PostgreSQL. Uses Dapper for data access and a hand-crafted schema (see `init/NE_schema_postgres.sql`). Currently only a minimal subset of writer/reader operations is implemented (Folders, minimal Block creation, Roll insert & latest Roll query) with many extension points stubbed.

## Features (current)
- Create folder hierarchy (`/Interpreter/folder`)
- Create minimal survey blocks (`/Interpreter/block-min`)
- Insert roll samples (`/Interpreter/roll` POST)
- Retrieve most recent roll sample for a block (`/Interpreter/roll` GET)
- Dockerized Postgres + API (via `docker-compose.yml`)
- Swagger UI in Development environment

## Tech Stack
- ASP.NET Core 8 Web API
- Dapper + Npgsql
- PostgreSQL 15 (initialized from `init/NE_schema_postgres.sql`)
- Dependency Injection (interfaces: `IDataWriter`, `IDataReader`)
- Docker / Docker Compose

## Project Structure (key parts)
- PostgresDataLoggerService/
  - Program.cs (service registration + pipeline)
  - Controllers/InterpreterController.cs (current API endpoints)
  - Data/
    - Interfaces/ (abstractions)
    - PostgresDataAccess.cs (implementation; many methods NotImplemented)
  - appsettings.json (base connection string; overridden in containers)
- init/NE_schema_postgres.sql (full schema bootstrap)
- docker-compose.yml (API + DB)

## Database
On first `docker-compose up`, Postgres runs the schema script mounted at `/docker-entrypoint-initdb.d`.  
Connection string override (compose):  
`ConnectionStrings__DefaultConnection=Host=db;Port=5432;Database=mydb;Username=postgres;Password=postgres`


# 🐳 Install Docker Desktop on Windows

## 1️⃣ Check System Requirements

Before installing, make sure your system meets the requirements:

- **Windows 10 64-bit** (Pro, Enterprise, or Education) or **Windows 11**
- **Hardware virtualization** enabled in BIOS
- **WSL 2 (Windows Subsystem for Linux)** feature enabled  
  *(Docker Desktop uses WSL 2 as its backend on Windows)*

---

## 2️⃣ Download Docker Desktop

1. Go to the official Docker website:  
   [https://www.docker.com/products/docker-desktop/](https://www.docker.com/products/docker-desktop/)
2. Click **“Download for Windows”**.
3. Save the installer file (e.g., `Docker Desktop Installer.exe`).

---

## 3️⃣ Install Docker Desktop

1. Run the downloaded installer.  
2. In the setup wizard:
   - Ensure **“Use WSL 2 instead of Hyper-V”** is checked (recommended).  
   - Click **OK** and continue the installation.  
3. When installation finishes, restart your computer if prompted.

---

## 4️⃣ First Launch

1. After reboot, launch **Docker Desktop** from the Start Menu.  
2. Accept the service agreement if asked.  
3. Wait for Docker to start — you’ll see a **whale icon 🐳** in the system tray once it’s running.

# PostgreSQL + pgAdmin Setup on Windows

## 1️⃣ Download

1. Go to the official PostgreSQL website:  
   [https://www.postgresql.org/download/windows/](https://www.postgresql.org/download/windows/)
2. Click **“Download the installer”** — this redirects to **EnterpriseDB**.
3. Download the latest **Windows x86-64** version.

---

## 2️⃣ Install

1. Run the downloaded `.exe` file.
2. Follow the setup wizard:
   - Keep default installation paths.
   - Make sure **pgAdmin 4** is selected.
   - Set a password for the **postgres** user (remember this!).
   - Leave the default port `5432`.
3. Complete the installation.

---

## 3️⃣ Open pgAdmin

1. Launch **pgAdmin 4** from the Start Menu.
2. Set a **master password** (used to store your saved connections securely).
3. In the sidebar, double-click **PostgreSQL 16** (or your version).
4. Enter the password you set for the **postgres** user.

   
# 🐘 Connect pgAdmin to PostgreSQL in Docker (Windows)

## 1️⃣ Open pgAdmin

1. Launch **pgAdmin 4** from the Start Menu.  
2. Enter your **master password** (if prompted).  

---

## 2️⃣ Create a New Server Connection

1. In pgAdmin, right-click **Servers → Create → Server…**  
2. In the **General** tab:  
   - **Name:** `Docker Postgres`  
3. In the **Connection** tab:  
   - **Host name / address:** `localhost`  
   - **Port:** `5432`  
   - **Username:** `postgres`  
   - **Password:** `admin`  
   *(Optional: check “Save Password”)*  
4. Click **Save**.  

---

## 3️⃣ Verify the Connection

You should now see **Docker Postgres** under the **Servers** list.  
Expand it to view:  
- Databases  
- Roles  
- Schemas  
