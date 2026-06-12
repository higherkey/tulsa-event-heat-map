# Tulsa Event Heat Map

> An interactive geospatial visualization tool designed to display event density and locations across the Tulsa metropolitan area.

[![standard-readme compliant](https://img.shields.io/badge/readme%20style-standard-brightgreen.svg?style=flat-square)](https://github.com/richardlitt/standard-readme)
[![Angular 21](https://img.shields.io/badge/Angular-21-DD0031?style=flat-square&logo=angular)](https://angular.dev/)
[![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![Mapbox GL JS](https://img.shields.io/badge/Mapbox--GL--JS-3-314351?style=flat-square&logo=mapbox)](https://www.mapbox.com/)
[![Vitest 4](https://img.shields.io/badge/Vitest-4-6E9F18?style=flat-square&logo=vitest)](https://vitest.dev/)

The Tulsa Event Heat Map provides a bird's-eye view of community activities, helping residents and organizers identify "hotspots" for local events. Whether it's festivals, community gatherings, or local markets, this tool translates data into an intuitive visual experience.

## Table of Contents

- [Background](#background)
- [Install](#install)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Background

This project leverages mapping engines and .NET API backends to enable high-performance spatial querying and data rendering of community events.

### Features
- **Interactive Map**: Pan and zoom across the Tulsa area with high-performance rendering.
- **Heat Map Overlay**: Dynamic visualization of event concentrations.
- **Responsive Interface**: Optimized for both desktop research and mobile on-the-go viewing.
- **Data Integration**: Ingests local event datasets for real-time visualization.

### Tech Stack details
- **Frontend**: Angular (v21.2.x) with TypeScript.
- **Mapping Engine**: Mapbox GL JS (v3.x).
- **Backend**: .NET Core / ASP.NET API (.NET 10).
- **Testing & Tooling**: Vitest (v4.x), Prettier.

---

## Install

### Prerequisites
- Node.js (LTS)
- Angular CLI: `npm install -g @angular/cli`
- .NET SDK 10.0+

### Dependency Installation

#### Frontend Setup
1. Navigate to the frontend directory:
   ```bash
   cd event-heatmap-ui
   ```
2. Install package dependencies:
   ```bash
   npm install
   ```

#### Backend Setup
No installation commands are needed beyond restoring dependencies during compilation/startup.

---

## Usage

### Running the Frontend
1. Navigate to the frontend folder:
   ```bash
   cd event-heatmap-ui
   ```
2. Start the local server:
   ```bash
   ng serve
   ```
3. Open `http://localhost:4200` in your browser.

### Running the Backend
1. Navigate to the backend folder:
   ```bash
   cd EventHeatmap.Api
   ```
2. Run the application:
   ```bash
   dotnet run
   ```

---

## Contributing

We welcome additions. Please check the `PROJECT.md` for project scope, coding guidelines, and database conventions.

---

## License

Built to celebrate and connect the Tulsa community. Standard copyright/proprietary rights apply.
