# Tulsa Event Heatmap Aggregator

## Vision
A visual aggregator showing where weekend crowds are heading in Tulsa, OK. Useful for gig-economy drivers, locals, or city planning.

## Competitive Edge
- **Agnostic Aggregation**: Unlike native Uber/DoorDash maps, we combine *all* event types (concerts, festivals, airport surges, community meetups) into one view.
- **The "Vibe Check"**: Bridging the gap between a static event list and real-time density, helping users decide where to go *now*.
- **Gig-Worker Optimized**: Specifically targeting high-traffic areas for rideshare and delivery efficiency.

## Architecture
- **Backend**: C# .NET Core Web API
    - RSS/XML/JSON Parsers for multiple event sources.
    - REST API endpoint `/api/events/heatmap` returning weighted event data.
    - Persistence layer for caching and aggregating diverse sources.
- **Frontend**: Angular (TypeScript)
    - Mapbox GL JS for interactive heatmap visualization.
    - Responsive design for mobile and desktop usage.

## Roadmap

### Phase 1: Persistence & Data Modeling
- Initialize Supabase (Postgres) and define the core `Events` schema.
- Configure .NET Backend with EF Core (Npgsql).
- Expose basic `/api/events/heatmap` endpoint.

### Phase 2: Data Acquisition (Scrapers & Integrations)
- Implement `RSSParserService` for **Tulsa World** and **City of Tulsa** feeds.
- Integrate **Ticketmaster Discovery API** for major local events.
- Implement a .NET `BackgroundService` for periodic data aggregation and attendance mocking.

### Phase 3: Frontend Foundation & Mapbox
- Initialize Mapbox GL JS in Angular.
- Create `MapboxService` centered on Tulsa (36.1540, -95.9928).
- Integrate `EventService` to consume the backend API.

### Phase 4: Heatmap Implementation
- Add Mapbox Heatmap Layer with weight-binding to `EstimatedAttendance`.
- Implement color gradients (Yellow -> Orange -> Red) for "heat" visualization.

### Phase 5: UI/UX Development
- Design and implement a cohesive UI/UX.
- Ensure responsive layouts for gig-economy drivers on mobile.
- *UI Style to be finalized during this phase.*

### Phase 6: Deployment & Launch
- Deploy Backend to **Render** (Docker).
- Deploy Frontend to **Vercel**.
- Configure environment variables and production API keys.

## Data Sources Research
- **Ticketmaster API**: (Confirmed) High potential for music/theatre events.
- **Tulsa World (JSON/RSS)**: (Confirmed) Excellent source for community events.
- **City of Tulsa**: (Confirmed) RSS/XML feeds for meetings and open datasets.
- **Meetup API**: (Potential) Good for community events; requires Pro account/OAuth.
- **Airport Arrivals (TUL)**: (Potential) High-value for rideshare drivers.
- **Snapchat Map**: (Limited) No public API for density; proprietary data.

## Tech Stack
- **Backend**: .NET SDK (v8+)
- **Frontend**: Angular & Mapbox GL JS
- **Database**: Supabase (Postgres)
- **Deployment**: Render (Backend), Vercel (Frontend)
- **Tooling**: Git & GitHub CLI (`gh`)
