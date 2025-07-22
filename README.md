# JobTracker
practice .Net 8, React and PostgresQL

🔧 Project: Job Application Tracker
A web app where users can:

Register/login

Add job applications (company name, position, status, salary, contact info)

Track statuses (e.g., Applied, Interview, Offer, Rejected)

Add notes, reminders, documents (CVs, cover letters)

(Optional) Export as PDF/CSV or email notifications


🧠 What You’ll Learn
Skill	Covered in this project
.NET 8 Web API (Minimal APIs)	Build fast, modern REST APIs
Entity Framework Core 8	Code-first DB, migrations, relationships
Auth with JWT	Secure login + role-based access
RESTful API design	Best practices for endpoints
Validation	Input validation with FluentValidation
Error handling & middleware	Custom error responses
Docker (optional)	For containerizing the app
Clean Architecture (optional)	Layer separation: API, Services, Repos

🌱 Phase-by-Phase Build Plan
🔹 Phase 1: Auth + Basic CRUD
Create DB with dotnet ef migrations

Register/Login (JWT)

Create, Read, Update, Delete jobs

🔹 Phase 2: Validation + Filtering
Add FluentValidation for inputs

Add filtering by status, company, date

Pagination (optional)

🔹 Phase 3: Notes, Files (Optional)
Add notes to each job

Upload files (CV, offer letters)

🔹 Phase 4: Polish
Swagger docs

Dockerfile + docker-compose.yml

Unit tests (xUnit or NUnit)

🧾 User Stories for Job Application Tracker (MVP)
🔐 Authentication
US-001: As a new user, I want to register with my email and password so I can create an account.

US-002: As a returning user, I want to log in securely so I can access my job applications.

US-003: As a logged-in user, I want to log out so I can protect my account on shared devices.
📄 Job Applications

US-004: As a user, I want to add a new job application with company name, position, and date so I can track my job search.

US-005: As a user, I want to view all job applications I've submitted in a list so I can see my job search history.

US-006: As a user, I want to edit details of a job application (like status or interview date) so I can keep my records up to date.

US-007: As a user, I want to delete a job application if it was added by mistake or is no longer needed.

📊 Status Tracking & Filtering
US-008: As a user, I want to filter applications by status (e.g., Applied, Interview, Offer, Rejected) so I can easily see my progress.

US-009: As a user, I want to see statistics (e.g., number of applications, interviews, offers) so I can analyze my job hunt (optional).

📝 Notes & Attachments (Optional Enhancements)
US-010: As a user, I want to add personal notes to each application (e.g., interview questions, follow-up details) so I can remember key info.

US-011: As a user, I want to upload and view documents (CV, cover letter, offer letter) for each job so I can organize related files.

👤 User Profile (Optional)
US-012: As a user, I want to view and update my profile (e.g., name, email, profile picture) so I can manage my account.

🧭 How to Use These
Treat each user story as a task or feature to implement.

Focus on US-001 to US-007 first — they form your core MVP.

Add the optional stories later as stretch goals.

