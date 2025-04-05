## Frontend Setup Instructions

### Install Dependencies
To install all required dependencies, run the following command:

```bash
npm instal
```

### Build the Project
To build the project, use the following command:
```
npm run build
```

### Preview the Project
To preview the production build locally, run:
```
npm run preview
```

### Configuration
The application uses a .env file to manage environment-specific configurations. This includes:

- **VITE_BASE_URL:** The base URL for the backend API. This should be updated if the API endpoint changes.

- **VITE_TENANT_ID:** A unique tenant identifier in GUID format. This is crucial for multi-tenancy support.

Ensure that the TENANT_ID provided is a valid GUID. Although no additional information is stored about a tenant, this ID is essential for data segregation.

Each event created is associated with a tenant ID, and all subsequent requests will filter and return only those events that match the current tenant’s ID. This helps maintain data isolation across tenants.

## Backend & Testing

### Running the Test Project
1. Open the solution in Visual Studio.
2. Set the test project as the startup project.
3. Run the tests using the built-in Test Explorer.

### The testing project includes:
1. Unit and integration tests for event creation.
2. Validation of tenant ID and required fields.
3. Assertion of correct behavior under different input scenarios.

### Email Mocking
In this project, emails are **mocked** by storing them in a database instead of sending them out to real email addresses. This approach is particularly useful during development, testing, or when performing tasks like debugging email functionality without actually sending emails to users.

### Default Connection String Configuration
To ensure that the application connects to the correct database, the connection string in the appsettings.json file must be configured appropriately. By default, the application uses the DefaultConnection string for database connectivity.

### Steps to Update Connection String
1. Open appsettings.json.
2. Locate the ConnectionStrings section.
3. Update the DefaultConnection string with the correct server, database name, username, and password for your environment.
4. Save the file.

### Additional Notes
- All events are stored and retrieved based on the tenantId field to ensure multi-tenant separation.
- Ensure that the backend API is running and accessible from the specified base URL.
- When deploying to production, make sure to configure the .env file appropriately based on the environment.
- Always verify that the database connection string points to the correct database instance for the environment you're working in.
- Make sure to regularly apply any new migrations to ensure the database schema remains in sync with your application's data model.
