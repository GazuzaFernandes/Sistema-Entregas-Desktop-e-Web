

namespace DAL
{
    /* Codigo para criar o banco de dados.
       --
-- PostgreSQL database dump
--

-- Dumped from database version 13.1
-- Dumped by pg_dump version 13.1

-- Started on 2022-10-13 08:55:07

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

DROP DATABASE "RbDesktop";
--
-- TOC entry 3261 (class 1262 OID 182695)
-- Name: RbDesktop; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE "RbDesktop" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Portuguese_Brazil.1252';


ALTER DATABASE "RbDesktop" OWNER TO postgres;

\connect "RbDesktop"

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
-- TOC entry 201 (class 1259 OID 182704)
-- Name: amostracliente; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.amostracliente (
   amostraid integer NOT NULL,
   construtora character varying(100),
   dataentrega date,
   obra character varying(100),
   material character varying(300),
   statusobraid integer
);


ALTER TABLE public.amostracliente OWNER TO postgres;

--
-- TOC entry 3262 (class 0 OID 0)
-- Dependencies: 201
-- Name: TABLE amostracliente; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.amostracliente IS 'Tabela relacionada a pasta Amostra = Amostra Cliente essa tabela é utilizada no Projeto (Sistema Amostras = FrmAmostra)';


--
-- TOC entry 247 (class 1259 OID 182922)
-- Name: amostracliente_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.amostracliente_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.amostracliente_seq OWNER TO postgres;

--
-- TOC entry 3264 (class 0 OID 0)
-- Dependencies: 247
-- Name: amostracliente_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.amostracliente_seq OWNED BY public.amostracliente.amostraid;


--
-- TOC entry 219 (class 1259 OID 182840)
-- Name: cadastrarempresa; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.cadastrarempresa (
   empresaid integer NOT NULL,
   empresa character varying(350)
);


ALTER TABLE public.cadastrarempresa OWNER TO postgres;

--
-- TOC entry 3265 (class 0 OID 0)
-- Dependencies: 219
-- Name: TABLE cadastrarempresa; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.cadastrarempresa IS 'DAL - LOGISTICA - PROJETO - SISTEMA LOGISTICA - FORM CADASTRAR EMPRESA';


--
-- TOC entry 238 (class 1259 OID 182902)
-- Name: cadastrarempresa_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.cadastrarempresa_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.cadastrarempresa_seq OWNER TO postgres;

--
-- TOC entry 3266 (class 0 OID 0)
-- Dependencies: 238
-- Name: cadastrarempresa_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.cadastrarempresa_seq OWNED BY public.cadastrarempresa.empresaid;


--
-- TOC entry 220 (class 1259 OID 182845)
-- Name: cadastrarmadeira; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.cadastrarmadeira (
   madeiraid integer NOT NULL,
   pisomadeira character varying(350),
   m2caixa numeric(19,2)
);


ALTER TABLE public.cadastrarmadeira OWNER TO postgres;

--
-- TOC entry 3267 (class 0 OID 0)
-- Dependencies: 220
-- Name: TABLE cadastrarmadeira; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.cadastrarmadeira IS 'DAL - LOGISTICA - PROJETO - SISTEMA LOGISTICA - FORM CADASTRAR ITENS.';


--
-- TOC entry 237 (class 1259 OID 182900)
-- Name: cadastromadeira_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.cadastromadeira_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.cadastromadeira_seq OWNER TO postgres;

--
-- TOC entry 3268 (class 0 OID 0)
-- Dependencies: 237
-- Name: cadastromadeira_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.cadastromadeira_seq OWNED BY public.cadastrarmadeira.madeiraid;


--
-- TOC entry 206 (class 1259 OID 182747)
-- Name: clientesfInanceiro; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."clientesfInanceiro" (
   idcliente integer NOT NULL,
   "Nome" character varying(100)
);


ALTER TABLE public."clientesfInanceiro" OWNER TO postgres;

--
-- TOC entry 3269 (class 0 OID 0)
-- Dependencies: 206
-- Name: TABLE "clientesfInanceiro"; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public."clientesfInanceiro" IS 'Tabela relacionada a Financeiro = Cliente Financeiro é utilizada no Projeto (Sistema Financeiro = FrmClienteFinanceiro)';


--
-- TOC entry 243 (class 1259 OID 182914)
-- Name: clientefinanceiro_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.clientefinanceiro_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.clientefinanceiro_seq OWNER TO postgres;

--
-- TOC entry 3270 (class 0 OID 0)
-- Dependencies: 243
-- Name: clientefinanceiro_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.clientefinanceiro_seq OWNED BY public."clientesfInanceiro".idcliente;


--
-- TOC entry 216 (class 1259 OID 182818)
-- Name: dadosproposta; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.dadosproposta (
   propostaid integer NOT NULL,
   dataprevista date,
   datapedido date,
   fabrica character varying(19),
   faturado character varying(19),
   "formaPag" character varying(19),
   engresp character varying(55),
   telefone character varying(19),
   pdrb character varying(6),
   pdvenda character varying(10),
   material character varying(955),
   proposta character varying(19),
   construtora character varying(22),
   obra character varying(55),
   dataentrega date,
   recebidopor character varying(19),
   notafiscal character varying(19),
   carreto character varying(19),
   statusobraid integer
);


ALTER TABLE public.dadosproposta OWNER TO postgres;

--
-- TOC entry 3271 (class 0 OID 0)
-- Dependencies: 216
-- Name: TABLE dadosproposta; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.dadosproposta IS 'DAL - Logistica // Projeto - Sistema Logistica - Form Proposta';


--
-- TOC entry 236 (class 1259 OID 182898)
-- Name: dadosproposta_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.dadosproposta_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.dadosproposta_seq OWNER TO postgres;

--
-- TOC entry 3272 (class 0 OID 0)
-- Dependencies: 236
-- Name: dadosproposta_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.dadosproposta_seq OWNED BY public.dadosproposta.propostaid;


--
-- TOC entry 223 (class 1259 OID 182863)
-- Name: dataestoque; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.dataestoque (
   dataid integer NOT NULL,
   saida date,
   entrada date,
   estoqueid integer,
   metroquadrado numeric(5,2),
   statusobraid integer
);


ALTER TABLE public.dataestoque OWNER TO postgres;

--
-- TOC entry 3273 (class 0 OID 0)
-- Dependencies: 223
-- Name: TABLE dataestoque; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.dataestoque IS 'DAL LOGISTICA - PROJETO SISTEMA LOGISTICA - FORM ESTOQUE MADEIRA';


--
-- TOC entry 235 (class 1259 OID 182896)
-- Name: dataestoque_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.dataestoque_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.dataestoque_seq OWNER TO postgres;

--
-- TOC entry 3274 (class 0 OID 0)
-- Dependencies: 235
-- Name: dataestoque_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.dataestoque_seq OWNED BY public.dataestoque.dataid;


--
-- TOC entry 224 (class 1259 OID 182868)
-- Name: datamaterial; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.datamaterial (
   dataid integer NOT NULL,
   dataentrada date,
   entrada numeric(9,2),
   fabrica character varying(55),
   obra character varying(55),
   materialid integer
);


ALTER TABLE public.datamaterial OWNER TO postgres;

--
-- TOC entry 3275 (class 0 OID 0)
-- Dependencies: 224
-- Name: TABLE datamaterial; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.datamaterial IS 'DAL LOGISTICA - PROJETO - SISTEMA LOGISTICA - FORM ESTOQUE';


--
-- TOC entry 234 (class 1259 OID 182894)
-- Name: datamaterial_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.datamaterial_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.datamaterial_seq OWNER TO postgres;

--
-- TOC entry 3276 (class 0 OID 0)
-- Dependencies: 234
-- Name: datamaterial_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.datamaterial_seq OWNED BY public.datamaterial.dataid;


--
-- TOC entry 212 (class 1259 OID 182793)
-- Name: dataprodutoorcamento; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.dataprodutoorcamento (
   dataid integer NOT NULL,
   data date,
   preco character varying(19),
   produtoid integer
);


ALTER TABLE public.dataprodutoorcamento OWNER TO postgres;

--
-- TOC entry 3277 (class 0 OID 0)
-- Dependencies: 212
-- Name: TABLE dataprodutoorcamento; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.dataprodutoorcamento IS 'DAL - Orçamento // Projeto - Sistema Orçamento - Form Cadastro Valores';


--
-- TOC entry 227 (class 1259 OID 182880)
-- Name: dataprodutoorcamento_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.dataprodutoorcamento_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.dataprodutoorcamento_seq OWNER TO postgres;

--
-- TOC entry 3278 (class 0 OID 0)
-- Dependencies: 227
-- Name: dataprodutoorcamento_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.dataprodutoorcamento_seq OWNED BY public.dataprodutoorcamento.dataid;


--
-- TOC entry 200 (class 1259 OID 182696)
-- Name: estoqueamostra; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.estoqueamostra (
   estoqueid integer NOT NULL,
   amostra character varying(600),
   entrada numeric(19,2),
   total numeric(19,2)
);


ALTER TABLE public.estoqueamostra OWNER TO postgres;

--
-- TOC entry 3279 (class 0 OID 0)
-- Dependencies: 200
-- Name: TABLE estoqueamostra; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.estoqueamostra IS 'Tabela relacionada a pasta Amostra = Amostra Estoque é utilizada no Projeto (Sistema Financeiro = FrmEstoqueAmostra)';


--
-- TOC entry 246 (class 1259 OID 182920)
-- Name: estoqueamostra_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.estoqueamostra_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.estoqueamostra_seq OWNER TO postgres;

--
-- TOC entry 3280 (class 0 OID 0)
-- Dependencies: 246
-- Name: estoqueamostra_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.estoqueamostra_seq OWNED BY public.estoqueamostra.estoqueid;


--
-- TOC entry 225 (class 1259 OID 182873)
-- Name: estoquemadeira; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.estoquemadeira (
   estoqueid integer NOT NULL,
   madeira character varying(350),
   espessura numeric(5,2),
   largura numeric(5,2),
   metrolinear numeric(5,2),
   metroquadrado numeric(5,2),
   metrocubico numeric(5,2)
);


ALTER TABLE public.estoquemadeira OWNER TO postgres;

--
-- TOC entry 3281 (class 0 OID 0)
-- Dependencies: 225
-- Name: TABLE estoquemadeira; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.estoquemadeira IS 'DAL - LOGISTICA - PROJETO - SISTEMA LOGISTICA - FORM ESTOQUE MADEIRA';


--
-- TOC entry 233 (class 1259 OID 182892)
-- Name: estoquemadeira_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.estoquemadeira_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.estoquemadeira_seq OWNER TO postgres;

--
-- TOC entry 3282 (class 0 OID 0)
-- Dependencies: 233
-- Name: estoquemadeira_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.estoquemadeira_seq OWNED BY public.estoquemadeira.estoqueid;


--
-- TOC entry 215 (class 1259 OID 182813)
-- Name: ferramentas; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.ferramentas (
   ferramentaid integer NOT NULL,
   funcionario character varying(55),
   retirada date,
   devolucao date,
   material character varying(100),
   statusobraid integer
);


ALTER TABLE public.ferramentas OWNER TO postgres;

--
-- TOC entry 3283 (class 0 OID 0)
-- Dependencies: 215
-- Name: TABLE ferramentas; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.ferramentas IS 'DAL - Logistica // PROJETO - Sistema Logistica - Form Ferramentas';


--
-- TOC entry 232 (class 1259 OID 182890)
-- Name: ferramentas_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.ferramentas_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.ferramentas_seq OWNER TO postgres;

--
-- TOC entry 3284 (class 0 OID 0)
-- Dependencies: 232
-- Name: ferramentas_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.ferramentas_seq OWNED BY public.ferramentas.ferramentaid;


--
-- TOC entry 209 (class 1259 OID 182766)
-- Name: financeiroproposta; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.financeiroproposta (
   idprop integer NOT NULL,
   emissaonf date,
   vencimentonf date,
   cliente character varying(100),
   proposta character varying(55),
   notafiscal character varying(10),
   obra character varying(55),
   comentario character varying(955),
   statusobraid integer
);


ALTER TABLE public.financeiroproposta OWNER TO postgres;

--
-- TOC entry 3285 (class 0 OID 0)
-- Dependencies: 209
-- Name: TABLE financeiroproposta; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.financeiroproposta IS 'Tabela = DAL - Financeiro - Projeto - Sistema Financeiro -  FrmNotaFiscalFinanceiro';


--
-- TOC entry 242 (class 1259 OID 182912)
-- Name: financeiroproposta_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.financeiroproposta_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.financeiroproposta_seq OWNER TO postgres;

--
-- TOC entry 3286 (class 0 OID 0)
-- Dependencies: 242
-- Name: financeiroproposta_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.financeiroproposta_seq OWNED BY public.financeiroproposta.idprop;


--
-- TOC entry 221 (class 1259 OID 182850)
-- Name: historico; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.historico (
   "HistoricoId" integer NOT NULL,
   datacomentario date,
   comentario character varying(955),
   propostaid integer
);


ALTER TABLE public.historico OWNER TO postgres;

--
-- TOC entry 3287 (class 0 OID 0)
-- Dependencies: 221
-- Name: TABLE historico; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.historico IS 'DAL LOGISTICA - PROJETO - SISTEMA LOGISTICA - FORM PROPOSTA';


--
-- TOC entry 231 (class 1259 OID 182888)
-- Name: historico_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.historico_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.historico_seq OWNER TO postgres;

--
-- TOC entry 3288 (class 0 OID 0)
-- Dependencies: 231
-- Name: historico_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.historico_seq OWNED BY public.historico."HistoricoId";


--
-- TOC entry 203 (class 1259 OID 182717)
-- Name: historicoengenharia; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.historicoengenharia (
   historicoid integer NOT NULL,
   comentario character varying(955),
   datacomentario date,
   comentadoeng character varying(19),
   engenheiroid integer
);


ALTER TABLE public.historicoengenharia OWNER TO postgres;

--
-- TOC entry 3289 (class 0 OID 0)
-- Dependencies: 203
-- Name: TABLE historicoengenharia; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.historicoengenharia IS 'Tabela relacionada a pasta Entenharia = Historico de Engenharia essa tabela é usada no Projeto - Sistema dos Engenheiros -  FrmPropostaEng';


--
-- TOC entry 245 (class 1259 OID 182918)
-- Name: historiengenharia_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.historiengenharia_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.historiengenharia_seq OWNER TO postgres;

--
-- TOC entry 3290 (class 0 OID 0)
-- Dependencies: 245
-- Name: historiengenharia_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.historiengenharia_seq OWNED BY public.historicoengenharia.historicoid;


--
-- TOC entry 218 (class 1259 OID 182834)
-- Name: itensproposta; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.itensproposta (
   itenid integer NOT NULL,
   material character varying(250),
   undmedida character varying(19),
   m2caixa numeric(19,2),
   quantidade numeric(19,2),
   preco numeric(19,2),
   qtdcaixa numeric(19,2),
   obsmaterial character varying(55),
   total numeric(19,2),
   propostaid integer,
   codigomaterial integer
);


ALTER TABLE public.itensproposta OWNER TO postgres;

--
-- TOC entry 3291 (class 0 OID 0)
-- Dependencies: 218
-- Name: TABLE itensproposta; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.itensproposta IS 'DAL - LOGISTICA / PROJETO - SISTEMA LOGISTICA - FORM PROPOSTA';


--
-- TOC entry 229 (class 1259 OID 182884)
-- Name: itenproposta_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.itenproposta_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.itenproposta_seq OWNER TO postgres;

--
-- TOC entry 3292 (class 0 OID 0)
-- Dependencies: 229
-- Name: itenproposta_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.itenproposta_seq OWNED BY public.itensproposta.itenid;


--
-- TOC entry 217 (class 1259 OID 182826)
-- Name: itenroteiromotorista; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.itenroteiromotorista (
   itensroteiroid integer NOT NULL,
   codigo integer,
   material character varying(955),
   undmedida character varying(19),
   qtdcaixas numeric,
   qtdsaida numeric,
   roteiroid integer
);


ALTER TABLE public.itenroteiromotorista OWNER TO postgres;

--
-- TOC entry 3293 (class 0 OID 0)
-- Dependencies: 217
-- Name: TABLE itenroteiromotorista; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.itenroteiromotorista IS 'DAL - LOGISTICA // PROJETO - SISTEMA LOGISTICA - FORM ROTEIRO';


--
-- TOC entry 230 (class 1259 OID 182886)
-- Name: itenroteiro_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.itenroteiro_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.itenroteiro_seq OWNER TO postgres;

--
-- TOC entry 3294 (class 0 OID 0)
-- Dependencies: 230
-- Name: itenroteiro_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.itenroteiro_seq OWNED BY public.itenroteiromotorista.itensroteiroid;


--
-- TOC entry 208 (class 1259 OID 182755)
-- Name: itensdatafinanceiro; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.itensdatafinanceiro (
   iddatas integer NOT NULL,
   fabrica character varying(19),
   datas date,
   entrada numeric(5,2),
   idmadeiras integer
);


ALTER TABLE public.itensdatafinanceiro OWNER TO postgres;

--
-- TOC entry 3295 (class 0 OID 0)
-- Dependencies: 208
-- Name: TABLE itensdatafinanceiro; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.itensdatafinanceiro IS 'Tabela referente - DAL - Financeiro . Projeto - Sistema Fianceiro - Form Estoque Financeiro';


--
-- TOC entry 241 (class 1259 OID 182910)
-- Name: itensdatafinanceiro_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.itensdatafinanceiro_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.itensdatafinanceiro_seq OWNER TO postgres;

--
-- TOC entry 3296 (class 0 OID 0)
-- Dependencies: 241
-- Name: itensdatafinanceiro_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.itensdatafinanceiro_seq OWNED BY public.itensdatafinanceiro.iddatas;


--
-- TOC entry 207 (class 1259 OID 182752)
-- Name: itensmadeirafinanceiro; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.itensmadeirafinanceiro (
   iddatas integer NOT NULL,
   fabrica character varying(55),
   datas date,
   entrada numeric(19,2),
   idprop integer
);


ALTER TABLE public.itensmadeirafinanceiro OWNER TO postgres;

--
-- TOC entry 3297 (class 0 OID 0)
-- Dependencies: 207
-- Name: TABLE itensmadeirafinanceiro; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.itensmadeirafinanceiro IS 'Tabela é referente a pasta Financeiro da DAL - Pojeto - Sistema Financeiro - Frm Nota Fiscal Financeiro';


--
-- TOC entry 240 (class 1259 OID 182906)
-- Name: itensmadeirafinanceiro_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.itensmadeirafinanceiro_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.itensmadeirafinanceiro_seq OWNER TO postgres;

--
-- TOC entry 3298 (class 0 OID 0)
-- Dependencies: 240
-- Name: itensmadeirafinanceiro_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.itensmadeirafinanceiro_seq OWNED BY public.itensmadeirafinanceiro.idprop;


--
-- TOC entry 222 (class 1259 OID 182858)
-- Name: itensmaterial; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.itensmaterial (
   materialid integer NOT NULL,
   material character varying(350),
   unidademedida character varying(19),
   total numeric(9,2),
   entrada numeric(9,2),
   quantidade numeric(9,2)
);


ALTER TABLE public.itensmaterial OWNER TO postgres;

--
-- TOC entry 3299 (class 0 OID 0)
-- Dependencies: 222
-- Name: TABLE itensmaterial; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.itensmaterial IS 'DAL LOGISTICA - PROJETO - SISTEMA LOGISTICA - FORM ESTOQUE';


--
-- TOC entry 205 (class 1259 OID 182736)
-- Name: madeirafinanceiro; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.madeirafinanceiro (
   idmadeiras integer NOT NULL,
   madeiras character varying(350),
   unidademedida character varying(10),
   total numeric(19,2),
   fabrica character varying(100),
   entrada numeric(19,2),
   statusobraid integer
);


ALTER TABLE public.madeirafinanceiro OWNER TO postgres;

--
-- TOC entry 3300 (class 0 OID 0)
-- Dependencies: 205
-- Name: TABLE madeirafinanceiro; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.madeirafinanceiro IS 'Tabela relacionada a pasta Financeiro = Madeira Financeiro essa Tabela é usada no Projeto - Sistema Fianceiro - FrmEstoqueFinanceiro';


--
-- TOC entry 239 (class 1259 OID 182904)
-- Name: madeirafinanceiro_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.madeirafinanceiro_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.madeirafinanceiro_seq OWNER TO postgres;

--
-- TOC entry 3301 (class 0 OID 0)
-- Dependencies: 239
-- Name: madeirafinanceiro_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.madeirafinanceiro_seq OWNED BY public.madeirafinanceiro.idmadeiras;


--
-- TOC entry 211 (class 1259 OID 182785)
-- Name: produtosorcamento; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.produtosorcamento (
   produtoid integer NOT NULL,
   fornecedor character varying(19),
   produto character varying(100),
   preco character varying(19),
   rendimento character varying(55),
   comentario character varying(955)
);


ALTER TABLE public.produtosorcamento OWNER TO postgres;

--
-- TOC entry 3302 (class 0 OID 0)
-- Dependencies: 211
-- Name: TABLE produtosorcamento; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.produtosorcamento IS 'DAL - Orçamento // Projeto - Sistema Orçamento - FrmCadastrarValores';


--
-- TOC entry 226 (class 1259 OID 182878)
-- Name: produtosorcamento_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.produtosorcamento_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.produtosorcamento_seq OWNER TO postgres;

--
-- TOC entry 3303 (class 0 OID 0)
-- Dependencies: 226
-- Name: produtosorcamento_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.produtosorcamento_seq OWNED BY public.produtosorcamento.produtoid;


--
-- TOC entry 202 (class 1259 OID 182712)
-- Name: propostaengenharia; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.propostaengenharia (
   engenhariaid integer NOT NULL,
   proposta character varying(55),
   cliente character varying(55),
   funcionario character varying(55),
   responsavel character varying(55),
   telefone character varying(55),
   obra character varying(55),
   statusobraid integer,
   datainclusao date
);


ALTER TABLE public.propostaengenharia OWNER TO postgres;

--
-- TOC entry 3304 (class 0 OID 0)
-- Dependencies: 202
-- Name: TABLE propostaengenharia; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.propostaengenharia IS 'Tabela relacionada a pasta Engenharia = Proposta Engenharia essa tabela é usada no Projeto - Sistema Fianceiro -FrmNotaFiscalFinanceiro';


--
-- TOC entry 244 (class 1259 OID 182916)
-- Name: propostaengenharia_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.propostaengenharia_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.propostaengenharia_seq OWNER TO postgres;

--
-- TOC entry 3305 (class 0 OID 0)
-- Dependencies: 244
-- Name: propostaengenharia_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.propostaengenharia_seq OWNED BY public.propostaengenharia.engenhariaid;


--
-- TOC entry 214 (class 1259 OID 182808)
-- Name: roteiromotorista; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.roteiromotorista (
   roteiroid integer NOT NULL,
   dataentrada date,
   proposta character varying(19),
   obra character varying(55),
   funcionario character varying(55)
);


ALTER TABLE public.roteiromotorista OWNER TO postgres;

--
-- TOC entry 3306 (class 0 OID 0)
-- Dependencies: 214
-- Name: TABLE roteiromotorista; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.roteiromotorista IS 'DAL - Logistica / Projeto - Sistema Logistica - Form Roteiro';


--
-- TOC entry 228 (class 1259 OID 182882)
-- Name: roteiromotorista_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.roteiromotorista_seq
   START WITH 1
   INCREMENT BY 1
   NO MINVALUE
   MAXVALUE 2147483647
   CACHE 1;


ALTER TABLE public.roteiromotorista_seq OWNER TO postgres;

--
-- TOC entry 3307 (class 0 OID 0)
-- Dependencies: 228
-- Name: roteiromotorista_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.roteiromotorista_seq OWNED BY public.roteiromotorista.roteiroid;


--
-- TOC entry 210 (class 1259 OID 182780)
-- Name: senha; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.senha (
   usuarioid integer NOT NULL,
   senhas character varying(19),
   ativo boolean
);


ALTER TABLE public.senha OWNER TO postgres;

--
-- TOC entry 3308 (class 0 OID 0)
-- Dependencies: 210
-- Name: TABLE senha; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.senha IS 'Senhas do sistemas';


--
-- TOC entry 204 (class 1259 OID 182731)
-- Name: statusobra; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.statusobra (
   statusobraid integer NOT NULL,
   descricao character varying(55)
);


ALTER TABLE public.statusobra OWNER TO postgres;

--
-- TOC entry 213 (class 1259 OID 182803)
-- Name: usuario; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.usuario (
   usuarioid integer NOT NULL,
   senha integer,
   ativo boolean
);


ALTER TABLE public.usuario OWNER TO postgres;

--
-- TOC entry 3309 (class 0 OID 0)
-- Dependencies: 213
-- Name: TABLE usuario; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.usuario IS 'DAL - Logistica ';


--
-- TOC entry 3209 (class 0 OID 182704)
-- Dependencies: 201
-- Data for Name: amostracliente; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3227 (class 0 OID 182840)
-- Dependencies: 219
-- Data for Name: cadastrarempresa; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3228 (class 0 OID 182845)
-- Dependencies: 220
-- Data for Name: cadastrarmadeira; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3214 (class 0 OID 182747)
-- Dependencies: 206
-- Data for Name: clientesfInanceiro; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3224 (class 0 OID 182818)
-- Dependencies: 216
-- Data for Name: dadosproposta; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3231 (class 0 OID 182863)
-- Dependencies: 223
-- Data for Name: dataestoque; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3232 (class 0 OID 182868)
-- Dependencies: 224
-- Data for Name: datamaterial; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3220 (class 0 OID 182793)
-- Dependencies: 212
-- Data for Name: dataprodutoorcamento; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3208 (class 0 OID 182696)
-- Dependencies: 200
-- Data for Name: estoqueamostra; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3233 (class 0 OID 182873)
-- Dependencies: 225
-- Data for Name: estoquemadeira; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3223 (class 0 OID 182813)
-- Dependencies: 215
-- Data for Name: ferramentas; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3217 (class 0 OID 182766)
-- Dependencies: 209
-- Data for Name: financeiroproposta; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3229 (class 0 OID 182850)
-- Dependencies: 221
-- Data for Name: historico; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3211 (class 0 OID 182717)
-- Dependencies: 203
-- Data for Name: historicoengenharia; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3225 (class 0 OID 182826)
-- Dependencies: 217
-- Data for Name: itenroteiromotorista; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3216 (class 0 OID 182755)
-- Dependencies: 208
-- Data for Name: itensdatafinanceiro; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3215 (class 0 OID 182752)
-- Dependencies: 207
-- Data for Name: itensmadeirafinanceiro; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3230 (class 0 OID 182858)
-- Dependencies: 222
-- Data for Name: itensmaterial; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3226 (class 0 OID 182834)
-- Dependencies: 218
-- Data for Name: itensproposta; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3213 (class 0 OID 182736)
-- Dependencies: 205
-- Data for Name: madeirafinanceiro; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3219 (class 0 OID 182785)
-- Dependencies: 211
-- Data for Name: produtosorcamento; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3210 (class 0 OID 182712)
-- Dependencies: 202
-- Data for Name: propostaengenharia; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3222 (class 0 OID 182808)
-- Dependencies: 214
-- Data for Name: roteiromotorista; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3218 (class 0 OID 182780)
-- Dependencies: 210
-- Data for Name: senha; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.senha (usuarioid, senhas, ativo) VALUES (1, 'q1s2e3f4t5@@', true);


--
-- TOC entry 3212 (class 0 OID 182731)
-- Dependencies: 204
-- Data for Name: statusobra; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3221 (class 0 OID 182803)
-- Dependencies: 213
-- Data for Name: usuario; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3310 (class 0 OID 0)
-- Dependencies: 247
-- Name: amostracliente_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.amostracliente_seq', 1, false);


--
-- TOC entry 3311 (class 0 OID 0)
-- Dependencies: 238
-- Name: cadastrarempresa_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.cadastrarempresa_seq', 1, false);


--
-- TOC entry 3312 (class 0 OID 0)
-- Dependencies: 237
-- Name: cadastromadeira_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.cadastromadeira_seq', 1, false);


--
-- TOC entry 3313 (class 0 OID 0)
-- Dependencies: 243
-- Name: clientefinanceiro_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.clientefinanceiro_seq', 1, false);


--
-- TOC entry 3314 (class 0 OID 0)
-- Dependencies: 236
-- Name: dadosproposta_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.dadosproposta_seq', 4, true);


--
-- TOC entry 3315 (class 0 OID 0)
-- Dependencies: 235
-- Name: dataestoque_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.dataestoque_seq', 1, false);


--
-- TOC entry 3316 (class 0 OID 0)
-- Dependencies: 234
-- Name: datamaterial_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.datamaterial_seq', 1, false);


--
-- TOC entry 3317 (class 0 OID 0)
-- Dependencies: 227
-- Name: dataprodutoorcamento_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.dataprodutoorcamento_seq', 1, false);


--
-- TOC entry 3318 (class 0 OID 0)
-- Dependencies: 246
-- Name: estoqueamostra_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.estoqueamostra_seq', 1, false);


--
-- TOC entry 3319 (class 0 OID 0)
-- Dependencies: 233
-- Name: estoquemadeira_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.estoquemadeira_seq', 1, false);


--
-- TOC entry 3320 (class 0 OID 0)
-- Dependencies: 232
-- Name: ferramentas_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.ferramentas_seq', 1, false);


--
-- TOC entry 3321 (class 0 OID 0)
-- Dependencies: 242
-- Name: financeiroproposta_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.financeiroproposta_seq', 1, false);


--
-- TOC entry 3322 (class 0 OID 0)
-- Dependencies: 231
-- Name: historico_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.historico_seq', 1, false);


--
-- TOC entry 3323 (class 0 OID 0)
-- Dependencies: 245
-- Name: historiengenharia_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.historiengenharia_seq', 1, false);


--
-- TOC entry 3324 (class 0 OID 0)
-- Dependencies: 229
-- Name: itenproposta_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.itenproposta_seq', 1, false);


--
-- TOC entry 3325 (class 0 OID 0)
-- Dependencies: 230
-- Name: itenroteiro_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.itenroteiro_seq', 1, false);


--
-- TOC entry 3326 (class 0 OID 0)
-- Dependencies: 241
-- Name: itensdatafinanceiro_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.itensdatafinanceiro_seq', 1, false);


--
-- TOC entry 3327 (class 0 OID 0)
-- Dependencies: 240
-- Name: itensmadeirafinanceiro_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.itensmadeirafinanceiro_seq', 1, false);


--
-- TOC entry 3328 (class 0 OID 0)
-- Dependencies: 239
-- Name: madeirafinanceiro_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.madeirafinanceiro_seq', 1, false);


--
-- TOC entry 3329 (class 0 OID 0)
-- Dependencies: 226
-- Name: produtosorcamento_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.produtosorcamento_seq', 1, false);


--
-- TOC entry 3330 (class 0 OID 0)
-- Dependencies: 244
-- Name: propostaengenharia_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.propostaengenharia_seq', 1, false);


--
-- TOC entry 3331 (class 0 OID 0)
-- Dependencies: 228
-- Name: roteiromotorista_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.roteiromotorista_seq', 1, false);


--
-- TOC entry 3039 (class 2606 OID 182825)
-- Name: dadosproposta DadosProposta_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dadosproposta
   ADD CONSTRAINT "DadosProposta_pkey" PRIMARY KEY (propostaid);


--
-- TOC entry 3003 (class 2606 OID 182711)
-- Name: amostracliente amostracliente_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.amostracliente
   ADD CONSTRAINT amostracliente_pkey PRIMARY KEY (amostraid);


--
-- TOC entry 3047 (class 2606 OID 182844)
-- Name: cadastrarempresa cadastrarempresa_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cadastrarempresa
   ADD CONSTRAINT cadastrarempresa_pkey PRIMARY KEY (empresaid);


--
-- TOC entry 3049 (class 2606 OID 182849)
-- Name: cadastrarmadeira cadastrarmadeira_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cadastrarmadeira
   ADD CONSTRAINT cadastrarmadeira_pkey PRIMARY KEY (madeiraid);


--
-- TOC entry 3015 (class 2606 OID 182751)
-- Name: clientesfInanceiro clientesfInanceiro_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."clientesfInanceiro"
   ADD CONSTRAINT "clientesfInanceiro_pkey" PRIMARY KEY (idcliente);


--
-- TOC entry 3055 (class 2606 OID 182867)
-- Name: dataestoque dataestoque_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dataestoque
   ADD CONSTRAINT dataestoque_pkey PRIMARY KEY (dataid);


--
-- TOC entry 3059 (class 2606 OID 182872)
-- Name: datamaterial datamaterial_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.datamaterial
   ADD CONSTRAINT datamaterial_pkey PRIMARY KEY (dataid);


--
-- TOC entry 3031 (class 2606 OID 182797)
-- Name: dataprodutoorcamento dataprodutoorcamento_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dataprodutoorcamento
   ADD CONSTRAINT dataprodutoorcamento_pkey PRIMARY KEY (dataid);


--
-- TOC entry 3001 (class 2606 OID 182703)
-- Name: estoqueamostra estoqueamostra_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.estoqueamostra
   ADD CONSTRAINT estoqueamostra_pkey PRIMARY KEY (estoqueid);


--
-- TOC entry 3062 (class 2606 OID 182877)
-- Name: estoquemadeira estoquemadeira_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.estoquemadeira
   ADD CONSTRAINT estoquemadeira_pkey PRIMARY KEY (estoqueid);


--
-- TOC entry 3037 (class 2606 OID 182817)
-- Name: ferramentas ferramentas_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ferramentas
   ADD CONSTRAINT ferramentas_pkey PRIMARY KEY (ferramentaid);


--
-- TOC entry 3024 (class 2606 OID 182773)
-- Name: financeiroproposta financeiroproposta_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.financeiroproposta
   ADD CONSTRAINT financeiroproposta_pkey PRIMARY KEY (idprop);


--
-- TOC entry 3051 (class 2606 OID 182857)
-- Name: historico historico_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.historico
   ADD CONSTRAINT historico_pkey PRIMARY KEY ("HistoricoId");


--
-- TOC entry 3008 (class 2606 OID 182724)
-- Name: historicoengenharia historicoengenharia_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.historicoengenharia
   ADD CONSTRAINT historicoengenharia_pkey PRIMARY KEY (historicoid);


--
-- TOC entry 3042 (class 2606 OID 182833)
-- Name: itenroteiromotorista itenroteiro_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.itenroteiromotorista
   ADD CONSTRAINT itenroteiro_pkey PRIMARY KEY (itensroteiroid);


--
-- TOC entry 3022 (class 2606 OID 182909)
-- Name: itensdatafinanceiro itensdatafinanceiro_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.itensdatafinanceiro
   ADD CONSTRAINT itensdatafinanceiro_pkey PRIMARY KEY (iddatas);


--
-- TOC entry 3019 (class 2606 OID 182759)
-- Name: itensmadeirafinanceiro itensmadeirafinanceiro_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.itensmadeirafinanceiro
   ADD CONSTRAINT itensmadeirafinanceiro_pkey PRIMARY KEY (iddatas);


--
-- TOC entry 3053 (class 2606 OID 182862)
-- Name: itensmaterial itensmaterial_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.itensmaterial
   ADD CONSTRAINT itensmaterial_pkey PRIMARY KEY (materialid);


--
-- TOC entry 3045 (class 2606 OID 182838)
-- Name: itensproposta itensproposta_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.itensproposta
   ADD CONSTRAINT itensproposta_pkey PRIMARY KEY (itenid);


--
-- TOC entry 3013 (class 2606 OID 182740)
-- Name: madeirafinanceiro madeirafinanceiro_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.madeirafinanceiro
   ADD CONSTRAINT madeirafinanceiro_pkey PRIMARY KEY (idmadeiras);


--
-- TOC entry 3029 (class 2606 OID 182792)
-- Name: produtosorcamento produtosorcamento_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.produtosorcamento
   ADD CONSTRAINT produtosorcamento_pkey PRIMARY KEY (produtoid);


--
-- TOC entry 3005 (class 2606 OID 182716)
-- Name: propostaengenharia propostaengenharia_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.propostaengenharia
   ADD CONSTRAINT propostaengenharia_pkey PRIMARY KEY (engenhariaid);


--
-- TOC entry 3035 (class 2606 OID 182812)
-- Name: roteiromotorista roteiromotorista_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.roteiromotorista
   ADD CONSTRAINT roteiromotorista_pkey PRIMARY KEY (roteiroid);


--
-- TOC entry 3027 (class 2606 OID 182784)
-- Name: senha senha_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.senha
   ADD CONSTRAINT senha_pkey PRIMARY KEY (usuarioid);


--
-- TOC entry 3010 (class 2606 OID 182735)
-- Name: statusobra statusobra_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.statusobra
   ADD CONSTRAINT statusobra_pkey PRIMARY KEY (statusobraid);


--
-- TOC entry 3033 (class 2606 OID 182807)
-- Name: usuario usuario_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuario
   ADD CONSTRAINT usuario_pkey PRIMARY KEY (usuarioid);


--
-- TOC entry 3006 (class 1259 OID 182730)
-- Name: ChaveSecundaria_Historico_Eng; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "ChaveSecundaria_Historico_Eng" ON public.historicoengenharia USING btree (engenheiroid);


--
-- TOC entry 3025 (class 1259 OID 182779)
-- Name: fki_Chave_Secundaria; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "fki_Chave_Secundaria" ON public.financeiroproposta USING btree (statusobraid);


--
-- TOC entry 3043 (class 1259 OID 182950)
-- Name: fki_Chave_Secundaria_Dados_Proposta; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "fki_Chave_Secundaria_Dados_Proposta" ON public.itensproposta USING btree (propostaid);


--
-- TOC entry 3056 (class 1259 OID 182985)
-- Name: fki_Chave_Secundaria_Estoque_Madeira; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "fki_Chave_Secundaria_Estoque_Madeira" ON public.dataestoque USING btree (estoqueid);


--
-- TOC entry 3016 (class 1259 OID 182961)
-- Name: fki_Chave_Secundaria_Financeiro_Proposta; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "fki_Chave_Secundaria_Financeiro_Proposta" ON public.itensmadeirafinanceiro USING btree (idprop);


--
-- TOC entry 3020 (class 1259 OID 182944)
-- Name: fki_Chave_Secundaria_Itens_Data_Financeiro; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "fki_Chave_Secundaria_Itens_Data_Financeiro" ON public.itensdatafinanceiro USING btree (iddatas);


--
-- TOC entry 3060 (class 1259 OID 182979)
-- Name: fki_Chave_Secundaria_Itens_Material; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "fki_Chave_Secundaria_Itens_Material" ON public.datamaterial USING btree (materialid);


--
-- TOC entry 3040 (class 1259 OID 182967)
-- Name: fki_Chave_Secundaria_Roteiro_Motorista; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "fki_Chave_Secundaria_Roteiro_Motorista" ON public.itenroteiromotorista USING btree (roteiroid);


--
-- TOC entry 3057 (class 1259 OID 182973)
-- Name: fki_Chave_Secundaria_StatusObra; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "fki_Chave_Secundaria_StatusObra" ON public.dataestoque USING btree (statusobraid);


--
-- TOC entry 3011 (class 1259 OID 182746)
-- Name: fki_Fkey_Status; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "fki_Fkey_Status" ON public.madeirafinanceiro USING btree (statusobraid);


--
-- TOC entry 3017 (class 1259 OID 182765)
-- Name: fki_f; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX fki_f ON public.itensmadeirafinanceiro USING btree (idprop);


--
-- TOC entry 3073 (class 2606 OID 182945)
-- Name: itensproposta Chave_Secundaria_Dados_Proposta; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.itensproposta
   ADD CONSTRAINT "Chave_Secundaria_Dados_Proposta" FOREIGN KEY (propostaid) REFERENCES public.dadosproposta(propostaid) NOT VALID;


--
-- TOC entry 3074 (class 2606 OID 182951)
-- Name: historico Chave_Secundaria_Dados_Proposta; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.historico
   ADD CONSTRAINT "Chave_Secundaria_Dados_Proposta" FOREIGN KEY (propostaid) REFERENCES public.dadosproposta(propostaid) NOT VALID;


--
-- TOC entry 3076 (class 2606 OID 182980)
-- Name: dataestoque Chave_Secundaria_Estoque_Madeira; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dataestoque
   ADD CONSTRAINT "Chave_Secundaria_Estoque_Madeira" FOREIGN KEY (estoqueid) REFERENCES public.estoquemadeira(estoqueid) NOT VALID;


--
-- TOC entry 3067 (class 2606 OID 182956)
-- Name: itensmadeirafinanceiro Chave_Secundaria_Financeiro_Proposta; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.itensmadeirafinanceiro
   ADD CONSTRAINT "Chave_Secundaria_Financeiro_Proposta" FOREIGN KEY (idprop) REFERENCES public.financeiroproposta(idprop) NOT VALID;


--
-- TOC entry 3068 (class 2606 OID 182939)
-- Name: itensdatafinanceiro Chave_Secundaria_Itens_Data_Financeiro; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.itensdatafinanceiro
   ADD CONSTRAINT "Chave_Secundaria_Itens_Data_Financeiro" FOREIGN KEY (iddatas) REFERENCES public.itensmadeirafinanceiro(iddatas) NOT VALID;


--
-- TOC entry 3077 (class 2606 OID 182974)
-- Name: datamaterial Chave_Secundaria_Itens_Material; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.datamaterial
   ADD CONSTRAINT "Chave_Secundaria_Itens_Material" FOREIGN KEY (materialid) REFERENCES public.itensmaterial(materialid) NOT VALID;


--
-- TOC entry 3070 (class 2606 OID 182798)
-- Name: dataprodutoorcamento Chave_Secundaria_Produto_Orcamento; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dataprodutoorcamento
   ADD CONSTRAINT "Chave_Secundaria_Produto_Orcamento" FOREIGN KEY (dataid) REFERENCES public.produtosorcamento(produtoid) NOT VALID;


--
-- TOC entry 3065 (class 2606 OID 182725)
-- Name: historicoengenharia Chave_Secundaria_Proposta_Engenharia; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.historicoengenharia
   ADD CONSTRAINT "Chave_Secundaria_Proposta_Engenharia" FOREIGN KEY (engenheiroid) REFERENCES public.propostaengenharia(engenhariaid) NOT VALID;


--
-- TOC entry 3072 (class 2606 OID 182962)
-- Name: itenroteiromotorista Chave_Secundaria_Roteiro_Motorista; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.itenroteiromotorista
   ADD CONSTRAINT "Chave_Secundaria_Roteiro_Motorista" FOREIGN KEY (roteiroid) REFERENCES public.roteiromotorista(roteiroid) NOT VALID;


--
-- TOC entry 3066 (class 2606 OID 182741)
-- Name: madeirafinanceiro Chave_Secundaria_StatusObra; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.madeirafinanceiro
   ADD CONSTRAINT "Chave_Secundaria_StatusObra" FOREIGN KEY (statusobraid) REFERENCES public.statusobra(statusobraid) NOT VALID;


--
-- TOC entry 3069 (class 2606 OID 182774)
-- Name: financeiroproposta Chave_Secundaria_StatusObra; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.financeiroproposta
   ADD CONSTRAINT "Chave_Secundaria_StatusObra" FOREIGN KEY (statusobraid) REFERENCES public.statusobra(statusobraid) NOT VALID;


--
-- TOC entry 3063 (class 2606 OID 182924)
-- Name: amostracliente Chave_Secundaria_StatusObra; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.amostracliente
   ADD CONSTRAINT "Chave_Secundaria_StatusObra" FOREIGN KEY (statusobraid) REFERENCES public.statusobra(statusobraid) NOT VALID;


--
-- TOC entry 3064 (class 2606 OID 182929)
-- Name: propostaengenharia Chave_Secundaria_StatusObra; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.propostaengenharia
   ADD CONSTRAINT "Chave_Secundaria_StatusObra" FOREIGN KEY (statusobraid) REFERENCES public.statusobra(statusobraid) NOT VALID;


--
-- TOC entry 3071 (class 2606 OID 182934)
-- Name: dadosproposta Chave_Secundaria_StatusObra; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dadosproposta
   ADD CONSTRAINT "Chave_Secundaria_StatusObra" FOREIGN KEY (statusobraid) REFERENCES public.statusobra(statusobraid) NOT VALID;


--
-- TOC entry 3075 (class 2606 OID 182968)
-- Name: dataestoque Chave_Secundaria_StatusObra; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dataestoque
   ADD CONSTRAINT "Chave_Secundaria_StatusObra" FOREIGN KEY (statusobraid) REFERENCES public.statusobra(statusobraid) NOT VALID;


--
-- TOC entry 3263 (class 0 OID 0)
-- Dependencies: 201
-- Name: TABLE amostracliente; Type: ACL; Schema: public; Owner: postgres
--

REVOKE ALL ON TABLE public.amostracliente FROM postgres;


-- Completed on 2022-10-13 08:55:08

--
-- PostgreSQL database dump complete
--



    */

}
