/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2014                    */
/* Created on:     5/28/2022 4:08:04 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACCOUNT') and o.name = 'FK_ACCOUNT_OWN_CUSTOMER')
alter table ACCOUNT
   drop constraint FK_ACCOUNT_OWN_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH') and o.name = 'FK_BRANCH_HAS_BANK')
alter table BRANCH
   drop constraint FK_BRANCH_HAS_BANK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUSTOMER') and o.name = 'FK_CUSTOMER_GOT_BRANCH')
alter table CUSTOMER
   drop constraint FK_CUSTOMER_GOT_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUSTOMER') and o.name = 'FK_CUSTOMER_SERVE_EMPLOYEE')
alter table CUSTOMER
   drop constraint FK_CUSTOMER_SERVE_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'FK_EMPLOYEE_GOT__BRANCH')
alter table EMPLOYEE
   drop constraint FK_EMPLOYEE_GOT__BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('OFFER') and o.name = 'FK_OFFER_OFFER_BRANCH')
alter table OFFER
   drop constraint FK_OFFER_OFFER_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('OFFER') and o.name = 'FK_OFFER_OFFER2_LOAN')
alter table OFFER
   drop constraint FK_OFFER_OFFER2_LOAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PERFORM') and o.name = 'FK_PERFORM_PERFORM_EMPLOYEE')
alter table PERFORM
   drop constraint FK_PERFORM_PERFORM_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PERFORM') and o.name = 'FK_PERFORM_PERFORM2_LOAN')
alter table PERFORM
   drop constraint FK_PERFORM_PERFORM2_LOAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAKE') and o.name = 'FK_TAKE_TAKE_CUSTOMER')
alter table TAKE
   drop constraint FK_TAKE_TAKE_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAKE') and o.name = 'FK_TAKE_TAKE2_LOAN')
alter table TAKE
   drop constraint FK_TAKE_TAKE2_LOAN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ACCOUNT')
            and   name  = 'OWN_FK'
            and   indid > 0
            and   indid < 255)
   drop index ACCOUNT.OWN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACCOUNT')
            and   type = 'U')
   drop table ACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANK')
            and   type = 'U')
   drop table BANK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BRANCH')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index BRANCH.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BRANCH')
            and   type = 'U')
   drop table BRANCH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUSTOMER')
            and   name  = 'SERVE_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUSTOMER.SERVE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUSTOMER')
            and   name  = 'GOT_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUSTOMER.GOT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLOYEE')
            and   name  = 'GOT__FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLOYEE.GOT__FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE')
            and   type = 'U')
   drop table EMPLOYEE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAN')
            and   type = 'U')
   drop table LOAN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('OFFER')
            and   name  = 'OFFER2_FK'
            and   indid > 0
            and   indid < 255)
   drop index OFFER.OFFER2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('OFFER')
            and   name  = 'OFFER_FK'
            and   indid > 0
            and   indid < 255)
   drop index OFFER.OFFER_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('OFFER')
            and   type = 'U')
   drop table OFFER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PERFORM')
            and   name  = 'PERFORM2_FK'
            and   indid > 0
            and   indid < 255)
   drop index PERFORM.PERFORM2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PERFORM')
            and   name  = 'PERFORM_FK'
            and   indid > 0
            and   indid < 255)
   drop index PERFORM.PERFORM_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PERFORM')
            and   type = 'U')
   drop table PERFORM
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TAKE')
            and   name  = 'TAKE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index TAKE.TAKE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TAKE')
            and   name  = 'TAKE_FK'
            and   indid > 0
            and   indid < 255)
   drop index TAKE.TAKE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAKE')
            and   type = 'U')
   drop table TAKE
go

/*==============================================================*/
/* Table: ACCOUNT                                               */
/*==============================================================*/
create table ACCOUNT (
   BALANCE              int                  not null,
   ACCNUM               int                  not null,
   SSN                  int                  not null,
   TYPE                 varchar(50)          not null,
   constraint PK_ACCOUNT primary key (ACCNUM)
)
go

/*==============================================================*/
/* Index: OWN_FK                                                */
/*==============================================================*/




create nonclustered index OWN_FK on ACCOUNT (SSN ASC)
go

/*==============================================================*/
/* Table: BANK                                                  */
/*==============================================================*/
create table BANK (
   BANKNAME             varchar(50)          not null,
   CODE                 int                  not null,
   BANKADD              varchar(200)         not null,
   constraint PK_BANK primary key (CODE)
)
go

/*==============================================================*/
/* Table: BRANCH                                                */
/*==============================================================*/
create table BRANCH (
   BRANCHADD            varchar(180)         not null,
   BRANCHNUM            int                  not null,
   CODE                 int                  not null,
   constraint PK_BRANCH primary key (BRANCHNUM)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/




create nonclustered index HAS_FK on BRANCH (CODE ASC)
go

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   NAME                 varchar(120)         not null,
   SSN                  int                  not null,
   EMP_SSN              int                  not null,
   BRANCHNUM            int                  not null,
   PHONE                int                  not null,
   CUSTOMERADD          varchar(220)         not null,
   constraint PK_CUSTOMER primary key (SSN)
)
go

/*==============================================================*/
/* Index: GOT_FK                                                */
/*==============================================================*/




create nonclustered index GOT_FK on CUSTOMER (BRANCHNUM ASC)
go

/*==============================================================*/
/* Index: SERVE_FK                                              */
/*==============================================================*/




create nonclustered index SERVE_FK on CUSTOMER (EMP_SSN ASC)
go

/*==============================================================*/
/* Table: EMPLOYEE                                              */
/*==============================================================*/
create table EMPLOYEE (
   EMP_NAME             varchar(120)         not null,
   EMP_SSN              int                  not null,
   BRANCHNUM            int                  not null,
   EMP_PHONE            int                  not null,
   EMPLOYEEADD          varchar(250)         not null,
   constraint PK_EMPLOYEE primary key (EMP_SSN)
)
go

/*==============================================================*/
/* Index: GOT__FK                                               */
/*==============================================================*/




create nonclustered index GOT__FK on EMPLOYEE (BRANCHNUM ASC)
go

/*==============================================================*/
/* Table: LOAN                                                  */
/*==============================================================*/
create table LOAN (
   LOANTYPE             varchar(50)          not null,
   LOANNUM              int                  not null,
   LOANAMOUNT           int                  not null,
   STATUS               varchar(50)          not null,
   constraint PK_LOAN primary key (LOANNUM)
)
go

/*==============================================================*/
/* Table: OFFER                                                 */
/*==============================================================*/
create table OFFER (
   BRANCHNUM            int                  not null,
   LOANNUM              int                  not null,
   constraint PK_OFFER primary key (BRANCHNUM, LOANNUM)
)
go

/*==============================================================*/
/* Index: OFFER_FK                                              */
/*==============================================================*/




create nonclustered index OFFER_FK on OFFER (BRANCHNUM ASC)
go

/*==============================================================*/
/* Index: OFFER2_FK                                             */
/*==============================================================*/




create nonclustered index OFFER2_FK on OFFER (LOANNUM ASC)
go

/*==============================================================*/
/* Table: PERFORM                                               */
/*==============================================================*/
create table PERFORM (
   EMP_SSN              int                  not null,
   LOANNUM              int                  not null,
   constraint PK_PERFORM primary key (EMP_SSN, LOANNUM)
)
go

/*==============================================================*/
/* Index: PERFORM_FK                                            */
/*==============================================================*/




create nonclustered index PERFORM_FK on PERFORM (EMP_SSN ASC)
go

/*==============================================================*/
/* Index: PERFORM2_FK                                           */
/*==============================================================*/




create nonclustered index PERFORM2_FK on PERFORM (LOANNUM ASC)
go

/*==============================================================*/
/* Table: TAKE                                                  */
/*==============================================================*/
create table TAKE (
   SSN                  int                  not null,
   LOANNUM              int                  not null,
   constraint PK_TAKE primary key (SSN, LOANNUM)
)
go

/*==============================================================*/
/* Index: TAKE_FK                                               */
/*==============================================================*/




create nonclustered index TAKE_FK on TAKE (SSN ASC)
go

/*==============================================================*/
/* Index: TAKE2_FK                                              */
/*==============================================================*/




create nonclustered index TAKE2_FK on TAKE (LOANNUM ASC)
go

alter table ACCOUNT
   add constraint FK_ACCOUNT_OWN_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table BRANCH
   add constraint FK_BRANCH_HAS_BANK foreign key (CODE)
      references BANK (CODE)
go

alter table CUSTOMER
   add constraint FK_CUSTOMER_GOT_BRANCH foreign key (BRANCHNUM)
      references BRANCH (BRANCHNUM)
go

alter table CUSTOMER
   add constraint FK_CUSTOMER_SERVE_EMPLOYEE foreign key (EMP_SSN)
      references EMPLOYEE (EMP_SSN)
go

alter table EMPLOYEE
   add constraint FK_EMPLOYEE_GOT__BRANCH foreign key (BRANCHNUM)
      references BRANCH (BRANCHNUM)
go

alter table OFFER
   add constraint FK_OFFER_OFFER_BRANCH foreign key (BRANCHNUM)
      references BRANCH (BRANCHNUM)
go

alter table OFFER
   add constraint FK_OFFER_OFFER2_LOAN foreign key (LOANNUM)
      references LOAN (LOANNUM)
go

alter table PERFORM
   add constraint FK_PERFORM_PERFORM_EMPLOYEE foreign key (EMP_SSN)
      references EMPLOYEE (EMP_SSN)
go

alter table PERFORM
   add constraint FK_PERFORM_PERFORM2_LOAN foreign key (LOANNUM)
      references LOAN (LOANNUM)
go

alter table TAKE
   add constraint FK_TAKE_TAKE_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table TAKE
   add constraint FK_TAKE_TAKE2_LOAN foreign key (LOANNUM)
      references LOAN (LOANNUM)
go

