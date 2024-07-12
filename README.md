# Cloud-Based Event Management Solution

This comprehensive event management solution is built on Microsoft Azure, leveraging ASP.NET Core API for the backend and Blazor WebAssembly for the frontend. It provides a robust platform for organizing and managing events, with a focus on scalability, security, and real-time updates.

## Key Features

- **Event Creation and Management:** Easily create, edit, and manage events with details like date, time, location, description, and registration information.
- **User Registration and Ticketing:**  Enable users to register for events, purchase tickets, and receive confirmation emails.
- **Real-Time Updates:** Utilize Azure SignalR to provide real-time updates on event changes, registrations, and other relevant information.
- **Image and File Storage:**  Store event images and user-submitted CVs securely in Azure Blob Storage.
- **Secure Authentication:**  Ensure user security with Azure Active Directory B2C for authentication and authorization.
- **Serverless Functions:** Optimize performance with Azure Functions for image resizing, thumbnail generation, and email notifications.
- **Caching:** Improve responsiveness by caching data in Azure Redis.
- **Scalability:** The solution is designed to scale effortlessly on Azure to handle increased demand.

## Technical Stack

* **Backend:** ASP.NET Core API
* **Frontend:** Blazor WebAssembly
* **Cloud Provider:** Microsoft Azure
* **Database:** Azure SQL
* **Cache:** Azure Redis
* **Authentication:** Azure Active Directory B2C
* **Storage:** Azure Blob Storage
* **Real-time Communication:** Azure SignalR
* **Serverless Functions:** Azure Functions

## API Architecture

![API Architecture Diagram](https://raw.githubusercontent.com/Behnam-Vosoogh/EventManagmentSolution/master/repository%20%26%20Unit%20Of%20Work%20Pattern%20and%20the%20API%20Architecture.png)

The API follows a structured design using the Repository Pattern and Unit of Work Pattern to ensure data consistency and efficient communication between the backend and frontend.

## Data Model (ERD)

![Event Management System ERD](https://raw.githubusercontent.com/Behnam-Vosoogh/EventManagmentSolution/master/EventManagmentSystem%20ERD.jpg)

The Entity Relationship Diagram (ERD) illustrates the relationships between different entities within the system, such as Events, Users, Tickets, and more. 

