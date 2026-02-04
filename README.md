# 🏠 Address Management System

Ein vollständiges Adressverwaltungssystem mit ASP.NET Core MVC und MySQL.

A complete address management system built with ASP.NET Core MVC and MySQL.

---

## 📋 Inhaltsverzeichnis / Table of Contents

- [Über das Projekt / About](#über-das-projekt--about)
- [Funktionen / Features](#funktionen--features)
- [Technologien / Technologies](#technologien--technologies)
- [Voraussetzungen / Prerequisites](#voraussetzungen--prerequisites)
- [Installation](#installation)
- [Datenbankstruktur / Database Structure](#datenbankstruktur--database-structure)
- [Projektstruktur / Project Structure](#projektstruktur--project-structure)
- [Verwendung / Usage](#verwendung--usage)
- [Screenshots](#screenshots)
- [Architektur / Architecture](#architektur--architecture)
- [Entwicklung / Development](#entwicklung--development)
- [Autor / Author](#autor--author)

---

## 🎯 Über das Projekt / About

Dieses Projekt ist ein Adressverwaltungssystem, das mit ASP.NET Core MVC entwickelt wurde. Es ermöglicht das Hinzufügen, Anzeigen und Löschen von Adressen mit einer benutzerfreundlichen Weboberfläche.

This project is an address management system developed with ASP.NET Core MVC. It allows adding, viewing, and deleting addresses with a user-friendly web interface.

### Zweck / Purpose

- Lernen von ASP.NET Core MVC
- Verstehen der Architektur (Model-View-Controller)
- Arbeiten mit MySQL Datenbank
- Implementierung von CRUD-Operationen (Create, Read, Delete)

---

## ✨ Funktionen / Features

- ✅ **Adresse hinzufügen** / **Add Address**
  - Formularvalidierung / Form validation
  - Duplikatsprüfung / Duplicate check
  - Erfolgs-/Fehlermeldungen / Success/Error messages

- ✅ **Alle Adressen anzeigen** / **View All Addresses**
  - Tabellarische Darstellung / Tabular display
  - Sortierte Anzeige / Sorted display

- ✅ **Adresse löschen** / **Delete Address**
  - Bestätigungsdialog / Confirmation dialog
  - Sofortiges Feedback / Instant feedback

- ✅ **Duplikatschutz** / **Duplicate Protection**
  - UNIQUE Constraint auf Datenbankebene / Database-level UNIQUE constraint
  - Validierung in C# / Validation in C#

---

## 🛠️ Technologien / Technologies

### Backend
- **ASP.NET Core 8.0** - Web Framework
- **C# 12** - Programmiersprache / Programming Language
- **MySQL 8.0** - Datenbank / Database
- **MySql.Data** - MySQL Connector

### Frontend
- **HTML5** - Struktur / Structure
- **CSS3** - Styling
- **Razor** - Template Engine

### Architektur / Architecture
- **MVC Pattern** - Model-View-Controller
- **Layered Architecture** - Schichtenarchitektur
  - Presentation Layer (Controllers, Views)
  - Business Logic Layer (Services)
  - Data Access Layer (Database)

---

## 📦 Voraussetzungen / Prerequisites

Bevor du beginnst, stelle sicher, dass du Folgendes installiert hast:

Before you begin, ensure you have the following installed:

1. **Visual Studio 2022** (oder neuer / or newer)
   - Workload: ".NET desktop development"
   - [Download](https://visualstudio.microsoft.com/)

2. **.NET 8.0 SDK** (oder neuer / or newer)
   - [Download](https://dotnet.microsoft.com/download)

3. **MySQL Server 8.0** (oder neuer / or newer)
   - [Download](https://dev.mysql.com/downloads/mysql/)

4. **MySQL Workbench** (optional, aber empfohlen / optional but recommended)
   - [Download](https://dev.mysql.com/downloads/workbench/)

---

## 🚀 Installation

### Schritt 1: Repository klonen / Clone Repository
```bash
