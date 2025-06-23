CREATE TABLE sandrika_mgeli_events.received_events
(
    id BIGSERIAL PRIMARY KEY,
    event_published_at TIMESTAMPTZ NOT NULL,
    updated_at TIMESTAMPTZ,
    created_at TIMESTAMPTZ NOT NULL,
    event_type VARCHAR(200) NOT NULL,
    partition_key VARCHAR(200) NOT NULL,
    idempotency_key VARCHAR(200) NOT NULL,
    data JSON
);