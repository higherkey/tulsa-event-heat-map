# Tulsa Event Heatmap Aggregator

## Vision
A visual aggregator showing where weekend crowds are heading in Tulsa, OK. Useful for gig-economy drivers, locals, or city planning.

## Architecture
- **Backend**: C# .NET Core Web API
    - RSS/XML Parser for City of Tulsa events.
    - REST API endpoint `/api/events/heatmap` returning structured event data.
    - Mocked `EstimatedAttendance` based on event category.
- **Frontend**: Angular (TypeScript)
    - Mapbox GL JS for interactive heatmap visualization.
    - Brutalist UI aesthetic (thick black borders, bold elements).

## Core Requirements
1. **RSS/XML Parser**: Periodically fetch and parse City of Tulsa public event feeds.
2. **Event Model**: Title, Description, StartTime, Latitude, Longitude, and EstimatedAttendance.
3. **Mapbox Integration**: Interactive map centered on Tulsa (36.1540, -95.9928).
4. **Heatmap Layer**: Weighted intensity based on `EstimatedAttendance` using yellow/orange/red color gradients.
5. **Brutalist UI**: Wrap map container in thick black borders.

## Tech Stack
- **Backend**: .NET SDK (v8+)
- **Frontend**: Angular & Mapbox GL JS
- **Database**: Supabase (Postgres)
- **Deployment**: Render (Backend), Vercel (Frontend)
- **Tooling**: Git & GitHub CLI (`gh`)
