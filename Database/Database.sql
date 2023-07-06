--
-- PostgreSQL database dump
--

-- Dumped from database version 14.5
-- Dumped by pg_dump version 14.5

-- Started on 2023-07-02 19:08:52

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 212 (class 1259 OID 40995)
-- Name: Brands; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Brands" (
    "Id" uuid NOT NULL,
    "Name" text NOT NULL,
    "Description" text NOT NULL,
    "IdImage" uuid NOT NULL,
    "FechaBaja" timestamp with time zone
);


ALTER TABLE public."Brands" OWNER TO postgres;

--
-- TOC entry 213 (class 1259 OID 41007)
-- Name: Categories; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Categories" (
    "Id" uuid NOT NULL,
    "Name" text NOT NULL,
    "Icon" text NOT NULL,
    "IdImage" uuid NOT NULL,
    "IdFatherCategory" uuid,
    "FechaBaja" timestamp with time zone
);


ALTER TABLE public."Categories" OWNER TO postgres;

--
-- TOC entry 210 (class 1259 OID 40981)
-- Name: Images; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Images" (
    "Id" uuid NOT NULL,
    "Path" text NOT NULL,
    "AlternativeText" text NOT NULL,
    "FechaBaja" timestamp with time zone
);


ALTER TABLE public."Images" OWNER TO postgres;

--
-- TOC entry 214 (class 1259 OID 41024)
-- Name: Products; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Products" (
    "Id" uuid NOT NULL,
    "Name" text NOT NULL,
    "Description" text NOT NULL,
    "IdCategory" uuid NOT NULL,
    "IdBrand" uuid NOT NULL,
    "FechaBaja" timestamp with time zone
);


ALTER TABLE public."Products" OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 41041)
-- Name: ProductsImages; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."ProductsImages" (
    "Id" uuid NOT NULL,
    "Priority" integer NOT NULL,
    "IdProduct" uuid NOT NULL,
    "IdImage" uuid NOT NULL,
    "FechaBaja" timestamp with time zone
);


ALTER TABLE public."ProductsImages" OWNER TO postgres;

--
-- TOC entry 211 (class 1259 OID 40988)
-- Name: Texts; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Texts" (
    "Id" uuid NOT NULL,
    "Code" text NOT NULL,
    "Value" text NOT NULL,
    "FechaBaja" timestamp with time zone
);


ALTER TABLE public."Texts" OWNER TO postgres;

--
-- TOC entry 209 (class 1259 OID 40976)
-- Name: __EFMigrationsHistory; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);


ALTER TABLE public."__EFMigrationsHistory" OWNER TO postgres;

--
-- TOC entry 3357 (class 0 OID 40995)
-- Dependencies: 212
-- Data for Name: Brands; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Brands" ("Id", "Name", "Description", "IdImage", "FechaBaja") FROM stdin;
f314b133-10bc-4e4f-abab-1949975b98ef	Brand1	brand1 description	7b3f78bc-1f87-4236-ba10-35fd92de8f86	\N
\.


--
-- TOC entry 3358 (class 0 OID 41007)
-- Dependencies: 213
-- Data for Name: Categories; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Categories" ("Id", "Name", "Icon", "IdImage", "IdFatherCategory", "FechaBaja") FROM stdin;
cdeee854-710e-40af-b006-272f4cc12c2d	category1	icon	7b3f78bc-1f87-4236-ba10-35fd92de8f86	\N	\N
\.


--
-- TOC entry 3355 (class 0 OID 40981)
-- Dependencies: 210
-- Data for Name: Images; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Images" ("Id", "Path", "AlternativeText", "FechaBaja") FROM stdin;
7b3f78bc-1f87-4236-ba10-35fd92de8f86	path1	alternativo1	\N
3a9f14b9-6642-426b-ac96-c78dd313f366	path.path.product1	prodcut1image	\N
5e8982b2-3e29-4f47-be24-0103380960ba	path.path.product1	prodcut1image	\N
de7b82fd-fd8a-4c69-b7f0-7a0b068cdb36	path.path.product1	prodcut1image	\N
0e446d21-0350-497f-ab89-fb978bd1fe13	path.path.product1	prodcut1image	\N
\.


--
-- TOC entry 3359 (class 0 OID 41024)
-- Dependencies: 214
-- Data for Name: Products; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Products" ("Id", "Name", "Description", "IdCategory", "IdBrand", "FechaBaja") FROM stdin;
084d64cf-45ff-4175-92b7-b5c517d4752e	producto1	descr producto1	cdeee854-710e-40af-b006-272f4cc12c2d	f314b133-10bc-4e4f-abab-1949975b98ef	\N
49500385-d842-4171-967f-a318a08a9ccc	producto2	descr producto2	cdeee854-710e-40af-b006-272f4cc12c2d	f314b133-10bc-4e4f-abab-1949975b98ef	\N
4abac409-18ba-45b9-b9fa-c4a92368b990	producto1	descr producto1	cdeee854-710e-40af-b006-272f4cc12c2d	f314b133-10bc-4e4f-abab-1949975b98ef	\N
\.


--
-- TOC entry 3360 (class 0 OID 41041)
-- Dependencies: 215
-- Data for Name: ProductsImages; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."ProductsImages" ("Id", "Priority", "IdProduct", "IdImage", "FechaBaja") FROM stdin;
2c5294ce-465e-4fb4-8462-b0002727fc55	2	084d64cf-45ff-4175-92b7-b5c517d4752e	7b3f78bc-1f87-4236-ba10-35fd92de8f86	\N
f30a5890-3f83-447c-9bf5-38b3be14e430	1	084d64cf-45ff-4175-92b7-b5c517d4752e	3a9f14b9-6642-426b-ac96-c78dd313f366	\N
2e054f90-b8b0-4cda-9df4-6bb038200847	1	49500385-d842-4171-967f-a318a08a9ccc	de7b82fd-fd8a-4c69-b7f0-7a0b068cdb36	\N
90f12dc8-380e-4041-b47e-6408952b04e0	1	49500385-d842-4171-967f-a318a08a9ccc	7b3f78bc-1f87-4236-ba10-35fd92de8f86	2023-06-16 20:18:17.763+02
96318931-f9ad-48ba-b24f-07fab93dc112	1	49500385-d842-4171-967f-a318a08a9ccc	5e8982b2-3e29-4f47-be24-0103380960ba	\N
97849ec3-4a4a-4962-8d25-bd5bd882964a	2	49500385-d842-4171-967f-a318a08a9ccc	7b3f78bc-1f87-4236-ba10-35fd92de8f86	\N
a16db95f-5beb-491f-a76a-5eb908dad29a	1	4abac409-18ba-45b9-b9fa-c4a92368b990	7b3f78bc-1f87-4236-ba10-35fd92de8f86	\N
f38fcd85-5d50-465f-95a9-636ebc9314e0	1	4abac409-18ba-45b9-b9fa-c4a92368b990	0e446d21-0350-497f-ab89-fb978bd1fe13	\N
\.


--
-- TOC entry 3356 (class 0 OID 40988)
-- Dependencies: 211
-- Data for Name: Texts; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Texts" ("Id", "Code", "Value", "FechaBaja") FROM stdin;
\.


--
-- TOC entry 3354 (class 0 OID 40976)
-- Dependencies: 209
-- Data for Name: __EFMigrationsHistory; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
20230523193437_Inicial	7.0.0
\.


--
-- TOC entry 3195 (class 2606 OID 41001)
-- Name: Brands PK_Brands; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Brands"
    ADD CONSTRAINT "PK_Brands" PRIMARY KEY ("Id");


--
-- TOC entry 3199 (class 2606 OID 41013)
-- Name: Categories PK_Categories; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Categories"
    ADD CONSTRAINT "PK_Categories" PRIMARY KEY ("Id");


--
-- TOC entry 3190 (class 2606 OID 40987)
-- Name: Images PK_Images; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Images"
    ADD CONSTRAINT "PK_Images" PRIMARY KEY ("Id");


--
-- TOC entry 3203 (class 2606 OID 41030)
-- Name: Products PK_Products; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Products"
    ADD CONSTRAINT "PK_Products" PRIMARY KEY ("Id");


--
-- TOC entry 3207 (class 2606 OID 41045)
-- Name: ProductsImages PK_ProductsImages; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."ProductsImages"
    ADD CONSTRAINT "PK_ProductsImages" PRIMARY KEY ("Id");


--
-- TOC entry 3192 (class 2606 OID 40994)
-- Name: Texts PK_Texts; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Texts"
    ADD CONSTRAINT "PK_Texts" PRIMARY KEY ("Id");


--
-- TOC entry 3188 (class 2606 OID 40980)
-- Name: __EFMigrationsHistory PK___EFMigrationsHistory; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");


--
-- TOC entry 3193 (class 1259 OID 41056)
-- Name: IX_Brands_IdImage; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX "IX_Brands_IdImage" ON public."Brands" USING btree ("IdImage");


--
-- TOC entry 3196 (class 1259 OID 41057)
-- Name: IX_Categories_IdFatherCategory; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "IX_Categories_IdFatherCategory" ON public."Categories" USING btree ("IdFatherCategory");


--
-- TOC entry 3197 (class 1259 OID 41058)
-- Name: IX_Categories_IdImage; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX "IX_Categories_IdImage" ON public."Categories" USING btree ("IdImage");


--
-- TOC entry 3204 (class 1259 OID 41061)
-- Name: IX_ProductsImages_IdImage; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "IX_ProductsImages_IdImage" ON public."ProductsImages" USING btree ("IdImage");


--
-- TOC entry 3205 (class 1259 OID 41062)
-- Name: IX_ProductsImages_IdProduct; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "IX_ProductsImages_IdProduct" ON public."ProductsImages" USING btree ("IdProduct");


--
-- TOC entry 3200 (class 1259 OID 41059)
-- Name: IX_Products_IdBrand; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "IX_Products_IdBrand" ON public."Products" USING btree ("IdBrand");


--
-- TOC entry 3201 (class 1259 OID 41060)
-- Name: IX_Products_IdCategory; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "IX_Products_IdCategory" ON public."Products" USING btree ("IdCategory");


--
-- TOC entry 3208 (class 2606 OID 41002)
-- Name: Brands FK_Brands_Images_IdImage; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Brands"
    ADD CONSTRAINT "FK_Brands_Images_IdImage" FOREIGN KEY ("IdImage") REFERENCES public."Images"("Id") ON DELETE CASCADE;


--
-- TOC entry 3209 (class 2606 OID 41014)
-- Name: Categories FK_Categories_Categories_IdFatherCategory; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Categories"
    ADD CONSTRAINT "FK_Categories_Categories_IdFatherCategory" FOREIGN KEY ("IdFatherCategory") REFERENCES public."Categories"("Id");


--
-- TOC entry 3210 (class 2606 OID 41019)
-- Name: Categories FK_Categories_Images_IdImage; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Categories"
    ADD CONSTRAINT "FK_Categories_Images_IdImage" FOREIGN KEY ("IdImage") REFERENCES public."Images"("Id") ON DELETE CASCADE;


--
-- TOC entry 3213 (class 2606 OID 41046)
-- Name: ProductsImages FK_ProductsImages_Images_IdImage; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."ProductsImages"
    ADD CONSTRAINT "FK_ProductsImages_Images_IdImage" FOREIGN KEY ("IdImage") REFERENCES public."Images"("Id") ON DELETE CASCADE;


--
-- TOC entry 3214 (class 2606 OID 41051)
-- Name: ProductsImages FK_ProductsImages_Products_IdProduct; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."ProductsImages"
    ADD CONSTRAINT "FK_ProductsImages_Products_IdProduct" FOREIGN KEY ("IdProduct") REFERENCES public."Products"("Id") ON DELETE CASCADE;


--
-- TOC entry 3211 (class 2606 OID 41031)
-- Name: Products FK_Products_Brands_IdBrand; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Products"
    ADD CONSTRAINT "FK_Products_Brands_IdBrand" FOREIGN KEY ("IdBrand") REFERENCES public."Brands"("Id") ON DELETE CASCADE;


--
-- TOC entry 3212 (class 2606 OID 41036)
-- Name: Products FK_Products_Categories_IdCategory; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Products"
    ADD CONSTRAINT "FK_Products_Categories_IdCategory" FOREIGN KEY ("IdCategory") REFERENCES public."Categories"("Id") ON DELETE CASCADE;


-- Completed on 2023-07-02 19:08:52

--
-- PostgreSQL database dump complete
--

