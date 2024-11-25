# Bank Account Management Application Read Me File

## Overview

This repository contains an application designed to manage customer bank accounts, supporting various account types and specific functionality for both regular customers and bank staff. The primary functionality includes deposit, withdrawal, and interest calculation. Additionally, bank staff receive a 50% discount on transaction fees.

### Contents

- **Task 1**: `Task1.md` - Analysis and UML Class Diagram with detailed explanations of the design choices, including the use of object-oriented principles and SOLID principles. A UML diagram is also provided in `UML_Diagram.png`.
- **Task 2**: `Task2.cs` - Implementation of the UML classes in C#. This task includes inheritance, constructors, and methods for managing account information and transactions.
- **Task 3**: `Task3_GUI.cs` - A GUI prototype that integrates the account classes, allowing users to interact with different account types, perform transactions, and view account information.
- **Task 4**: GitHub Repository setup - Code organization, documentation, and repository setup guidelines.

---

## Scenario

The application facilitates deposit and withdrawal transactions for bank customers, supporting distinct account types with customized features. It also includes a fee discount for bank staff.

### Customers
Customers (including staff members) have the following attributes:
- **Customer Number**
- **Name**
- **Contact Details**

### Accounts
The application includes three account types:
1. **Everyday Account**
   - No interest, overdraft, or transaction fees.
2. **Investment Account**
   - Variable interest rates, no overdraft, fee for failed transactions, and interest calculation.
3. **Omni Account**
   - Interest applied on balances over $1000, specific overdraft limit, failed transaction fees, and simple deposit and interest calculation methods.

Each account type is implemented with attributes and methods for:
- **Unique ID**: Account identifier.
- **Balance**: Account balance.
- **Interest Rate**: Interest rate (if applicable).
- **Overdraft Limit**: Allowed overdraft limit (if applicable).
- **Failed Withdrawal Fee**: Fee for failed withdrawal attempts.
- **Deposit Method**: Adds to account balance.
- **Withdrawal Method**: Handles withdrawal, overdraft checks, and fee deduction.
- **Interest Calculation Method**: Calculates and adds interest to the balance (if applicable).

---

## Tasks

### Task 1 - UML Class Diagram and Explanation
- **File**: `Task1.md`
- **Diagram**: `UML_Diagram.png`

This document includes:
- A UML class diagram with associations, inheritance, and abstract classes.
- Detailed explanations of design choices, including object-oriented and SOLID principles.
- Use case scenarios demonstrating account management and transaction logging.

### Task 2 - C# Class Implementation
- **File**: `Task2.cs`

Implementation of the UML classes in C#, focusing on:
- **Inheritance and access modifiers** for encapsulation.
- **Constructors** with relevant parameters for each class.
- Methods for account information, balance management, and transaction details.
- Adherence to **C# coding standards** and best practices, with clear documentation for each class and method.

### Task 3 - GUI Form Prototype
- **File**: `Task3_GUI.cs`

A GUI prototype that integrates the account classes and provides a user interface for managing accounts:
- **Functionality**:
  - Account selection and information display.
  - Withdrawals, deposits, and interest calculation.
  - Transaction history displayed in a list box.
  - Error handling and input validation.
- **Sample Data**:
  - A hardcoded user "John Doe" with Everyday, Investment, and Omni accounts.

### Task 4 - GitHub Repository Setup
- **Repository**: [https://github.com/gracemorganmaxwell/CSharp_BankingApp_A1/edit/main/README.md]

All project files and documentation are organized within a private GitHub repository:
- **Access**: Add tutor as a collaborator for access.
- **Documentation**: All code and files are well-documented and organized to facilitate understanding and collaboration.

---

## Usage

Either clone or fork this repository and run the project files as per the requirements for each task. Ensure all dependencies and setup instructions are followed for a smooth experience with the GUI and C# implementations.
