# PostgresDataLoggerService

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
