# iCantina Management System

## Project Overview

The iCantina Management System is designed for a school's canteen to manage menus and reservations efficiently. The system facilitates the handling of daily menus, reservation controls, balance top-ups, and billing.

## Project Collaboration
This project was created with the collaborative efforts of three passionate individuals: <br>
[Maxim D.](https://www.maxdev.live/) <br>
[Edo S.](https://github.com/18pingu18) <br>
[Ana G.](https://github.com/ana-fg)

## Features

1. **User Roles**: 
   - The system is exclusively used by canteen staff.
   - Staff handle balance top-ups and reservations.

2. **Menu Management**:
   - Daily menus include a dish from each category (Meat, Fish, Vegetarian) and multiple extras.
   - Different prices for students and professors.
   - Weekly view of menus with navigation capabilities.

3. **Reservation System**:
   - Reservations decrease available quantity and deduct from customer balance.
   - Each customer can reserve one dish per day and up to three extras.
   - Generation of text files for reservation details and PDF invoices.
   - Support for penalty charges based on reservation delays.

4. **Customer Management**:
   - Customers can be categorized as students or professors.
   - New customers can be saved for future transactions.

5. **Employee Management**:
   - CRUD operations for employee records.
   - Switching active employee during application use.

6. **Data Persistence**:
   - All data is stored in a SQL Server database using Entity Framework.

## Data Model

The data model includes tables for employees, customers, dishes, extras, menus, reservations, and penalties. Detailed structure and justifications for any modifications are documented in the project report.

## User Interface

The application includes the following mandatory forms:

1. **Main Form**: Access to various functionalities like dishes, extras, menus, penalties, reservations, customers, and employees. Displays the current week's menus.
2. **Reservation Form**: Split into reservation creation and marking reservations as used.
3. **Dishes Form**: CRUD operations for dishes.
4. **Extras Form**: CRUD operations for extras.
5. **Penalties Form**: CRUD operations for penalty times.
6. **Customer Management Form**: CRUD operations for customer records.
7. **Menu Form**: Creation and management of daily menus.
8. **Employee Form**: CRUD operations for employee records.
