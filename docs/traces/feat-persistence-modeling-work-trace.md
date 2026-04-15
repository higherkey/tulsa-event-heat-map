# Work Trace - feat/persistence-modeling

## 1) Planned Work

### TODO List
- [x] Define Supabase SQL schema for `Events` table.
- [x] Install EF Core and Npgsql packages in `EventHeatmap.Api`.
- [x] Create `Event` model and `AppDbContext`.
- [x] Configure connection string in `appsettings.json`.
- [x] Create a basic `EventsController` with a `/api/events/heatmap` endpoint.
- [ ] Verify database connection and basic API response.

### File List
- `EventHeatmap.Api/Models/Event.cs`: The core event data model.
- `EventHeatmap.Api/Data/AppDbContext.cs`: The EF Core database context.
- `EventHeatmap.Api/Controllers/EventsController.cs`: The API controller for event data.
- `EventHeatmap.Api/Program.cs`: Database service configuration.
- `EventHeatmap.Api/appsettings.json`: Connection string configuration.

### Rationale
- **Models/Event.cs**: Defines the structure for events, including location (lat/long) and weight (EstimatedAttendance).
- **AppDbContext.cs**: Bridges the .NET models with the Supabase Postgres database.
- **EventsController.cs**: Provides the REST endpoint required by the frontend for heatmap visualization.

## 2) In Progress Work
- Active Files:
    - `EventHeatmap.Api/Program.cs`
    - `EventHeatmap.Api/appsettings.json`

## 3) Completed Work
- Summary: Defined SQL schema, installed EF Core/Npgsql, created data models, and implemented the initial API controller.

## 4) Issues and Out of Scope
- **4a) Potential Blockers**: None identified yet.
- **4b) Opportunities**: None identified yet.
