-- Table: public.Texts

-- DROP TABLE IF EXISTS public."Texts";

CREATE TABLE IF NOT EXISTS public."Texts"
(
    "Id" uuid NOT NULL,
    "Code" text COLLATE pg_catalog."default" NOT NULL,
    "Value" text COLLATE pg_catalog."default" NOT NULL,
    "FechaBaja" timestamp with time zone,
    CONSTRAINT "PK_Texts" PRIMARY KEY ("Id")
)

TABLESPACE pg_default;
