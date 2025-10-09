# PostgresDataLoggerService
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
