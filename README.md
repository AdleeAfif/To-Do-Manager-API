# To-Do Manager API

The To-Do Manager API is a simple task management API built using C# and ASP.NET Core. It allows users to manage their to-do list items with basic functionalities like creating, updating, deleting, and fetching tasks. This API uses local storage and does not require authorization, making it easy to set up and use for personal projects and learning purposes.

## Getting Started

To get started with the To-Do Manager API, follow these steps:

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your system.

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/To-Do-Manager-API.git
   ```

2. Navigate to the project directory:

   ```bash
   cd To-Do-Manager-API
   ```

3. Build and run the API:

   ```bash
   dotnet build
   dotnet run
   ```

The API will start running locally on `https://localhost:5001` (or `http://localhost:5000`).

## API Endpoints

### Get All Tasks

- **Endpoint:** `GET /api/tasks`
- **Description:** Get a list of all tasks.
- **Response:** JSON array containing task objects.

### Get Task by ID

- **Endpoint:** `GET /api/tasks/{id}`
- **Description:** Get a specific task by its ID.
- **Response:** JSON object representing the task.

### Create Task

- **Endpoint:** `POST /api/tasks`
- **Description:** Create a new task.
- **Request Body:** JSON object containing task details (title, description, due date, etc.).
- **Response:** JSON object representing the created task.

### Update Task

- **Endpoint:** `PUT /api/tasks/{id}`
- **Description:** Update an existing task by its ID.
- **Request Body:** JSON object containing updated task details.
- **Response:** JSON object representing the updated task.

### Delete Task

- **Endpoint:** `DELETE /api/tasks/{id}`
- **Description:** Delete a task by its ID.
- **Response:** JSON object representing the deleted task.

## Usage Example

### Using Swagger-UI

![image](https://github.com/AdleeAfif/To-Do-Manager-API/assets/91206203/e4c6c659-d6a7-42a2-bdcb-1ea271a67fb7)

