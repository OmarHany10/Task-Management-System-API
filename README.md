# Task Management System API  

## Overview  

The **Task Management System API** is designed to manage tasks, users, projects, and their interactions within an organization. The API supports features such as user authentication, task management, project tracking, and role-based access control (RBAC).  

## Features  

- User authentication with JWT and role-based access control (Admin, Project Manager, and User).  
- Manage tasks, including creating, updating, deleting, and assigning them to users.  
- Track overdue, upcoming, and completed tasks.  
- Manage projects, including assigning users and tracking project-specific tasks.  
- Full CRUD operations for users and projects (Admins only for some operations).  

---

## Technologies  

- **Backend**: .NET Core (C#)  
- **Authentication**: JWT with ASP.NET Core Identity  
- **Database**: SQL Server  
- **Architecture**: Layered Architecture with Services, Repositories, and DTOs  

---

## API Endpoints  

### Authentication  

- **POST /api/Authentication/Register**  
  Register a new user.  
  No authentication required.  

- **POST /api/Authentication/Login**  
  Log in a user to retrieve a JWT token.  
  No authentication required.  

- **POST /api/Authentication/AssignToRole**  
  Assign a role to a user (Admin only).  
  Requires Admin privileges.  

### User Management  

- **GET /api/User**  
  Retrieve all users (Admin only).  
  Requires Admin privileges.  

- **GET /api/User/{id}**  
  Retrieve a specific user by ID (Admin only).  
  Requires Admin privileges.  

- **PUT /api/User**  
  Update user details (Admin only).  
  Requires Admin privileges.  

- **DELETE /api/User**  
  Delete a user (Admin only).  
  Requires Admin privileges.  

- **GET /api/User/{id}/activity**  
  Retrieve all activities of a user.  
  Requires authentication.  

- **GET /api/User/{userId}/tasks**  
  Retrieve all tasks assigned to a specific user.  
  Requires authentication.  

- **GET /api/User/MyActivity**  
  Retrieve activities of the currently authenticated user.  
  Requires authentication.  

- **GET /api/User/MyTasks**  
  Retrieve tasks assigned to the currently authenticated user.  
  Requires authentication.  

### Project Management  

- **GET /api/Project**  
  Retrieve all projects.  
  Requires Project Manager privileges.  

- **GET /api/Project/{id}**  
  Retrieve details of a specific project.  
  Requires Project Manager privileges.  

- **POST /api/Project**  
  Create a new project.  
  Requires Project Manager privileges.  

- **PUT /api/Project**  
  Update an existing project.  
  Requires Project Manager privileges.  

- **DELETE /api/Project**  
  Delete a project.  
  Requires Project Manager privileges.  

- **GET /api/Project/{projectId}/Users**  
  Retrieve all users assigned to a project.  
  Requires Project Manager privileges.  

- **GET /api/Project/{projectId}/Tasks**  
  Retrieve all tasks associated with a project.  
  Requires Project Manager privileges.  

### Task Management  

- **GET /api/Task**  
  Retrieve all tasks.  
  Requires Project Manager privileges.  

- **GET /api/Task/{id}**  
  Retrieve details of a specific task.  
  Requires Project Manager privileges.  

- **GET /api/Task/{taskId}/Comments**  
  Retrieve all comments for a specific task.  
  Requires authentication.  

- **GET /api/Task/Overdue**  
  Retrieve all overdue tasks.  
  Requires Project Manager privileges.  

- **GET /api/Task/Upcoming**  
  Retrieve all upcoming tasks.  
  Requires Project Manager privileges.  

- **GET /api/Task/Finished**  
  Retrieve all completed tasks.  
  Requires Project Manager privileges.  

- **GET /api/Task/MyOverdue**  
  Retrieve overdue tasks assigned to the currently authenticated user.  
  Requires authentication.  

- **GET /api/Task/MyUpcoming**  
  Retrieve upcoming tasks assigned to the currently authenticated user.  
  Requires authentication.  

- **GET /api/Task/MyFinished**  
  Retrieve completed tasks assigned to the currently authenticated user.  
  Requires authentication.  

- **POST /api/Task**  
  Create a new task.  
  Requires Project Manager privileges.  

- **PUT /api/Task**  
  Update an existing task.  
  Requires Project Manager privileges.  

- **DELETE /api/Task**  
  Delete a task.  
  Requires Project Manager privileges.  

---
