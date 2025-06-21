CREATE TABLE sandrika_mgeli_events.received_events
(
    id SERIAL PRIMARY KEY,
    event_id VARCHAR(200) NOT NULL,
    event_published_at TIMESTAMPTZ NOT NULL,
    updated_at TIMESTAMPTZ,
    created_at TIMESTAMPTZ NOT NULL,
    event_type VARCHAR(100) NOT NULL,
    data JSON
);