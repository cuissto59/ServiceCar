create table __efmigrationshistory
(
    MigrationId    varchar(95) not null
        primary key,
    ProductVersion varchar(32) not null
);

create table user
(
    id_user  int auto_increment
        primary key,
    f_name   varchar(20) not null,
    l_name   varchar(20) not null,
    login    varchar(64) not null,
    password varchar(64) not null,
    is_admin bit         not null
);

create table conductor
(
    user             int          not null
        primary key,
    cin              varchar(20)  not null,
    telephone_number int          not null,
    adress           varchar(100) not null,
    active           bit          not null,
    constraint conductor_ibfk_1
        foreign key (user) references user (id_user)
);

create table vehicle
(
    id_vehicle        int auto_increment
        primary key,
    vehicle_conductor int          not null,
    img               varchar(100) not null,
    description       text         not null,
    in_use            bit          not null,
    constraint vehicle_ibfk_1
        foreign key (vehicle_conductor) references conductor (user)
);

create index vehicle_conductor
    on vehicle (vehicle_conductor);

create table vehicle_accident
(
    id_vehicle_ac      int         not null
        primary key,
    type               varchar(50) not null,
    damage_description text        not null,
    was_insured        bit         null,
    date               datetime    not null,
    constraint vehicle_accident_ibfk_1
        foreign key (id_vehicle_ac) references vehicle (id_vehicle)
);

create table vehicle_breakdown
(
    id_breakdown  int auto_increment
        primary key,
    id_vehicle_bd int         not null,
    problem       varchar(50) not null,
    description   text        not null,
    constraint vehicle_breakdown_ibfk_1
        foreign key (id_vehicle_bd) references vehicle (id_vehicle)
);

create index id_vehicle_bd
    on vehicle_breakdown (id_vehicle_bd);

create table vehicle_buy_contract
(
    id_vehicle_bc   int            not null
        primary key,
    provider        varchar(30)    null,
    buy_date        date           null,
    contract_number varchar(50)    null,
    warranty_years  int            null,
    amount          decimal(10, 2) null,
    tva             decimal(2, 2)  null,
    constraint vehicle_buy_contract_ibfk_1
        foreign key (id_vehicle_bc) references vehicle (id_vehicle)
);

create table vehicle_general_info
(
    id_vehicle_gi   int                                                 not null
        primary key,
    matricul_number varchar(30)                                         not null,
    code            varchar(20)                                         not null,
    grey_card       varchar(20)                                         not null,
    chassis_number  varchar(20)                                         not null,
    vehicle_type    enum ('Voiture', 'Camion')                          not null,
    acquisition     enum ('ACHAT')                                      not null,
    mark            varchar(20)                                         not null,
    model           varchar(20)                                         not null,
    model_year      int                                                 not null,
    in_use_yr       int                                                 not null,
    km              int                                                 not null,
    body_type       varchar(30)                                         not null,
    fuel_type       enum ('DIESEL', 'ESSENCE', 'HYBRIDE', 'ELECTRIQUE') not null,
    constraint vehicle_general_info_ibfk_1
        foreign key (id_vehicle_gi) references vehicle (id_vehicle)
);

create table vehicle_maintenance_plan
(
    id_vehicle_mp int  not null
        primary key,
    description   text not null,
    constraint vehicle_maintenance_plan_ibfk_1
        foreign key (id_vehicle_mp) references vehicle (id_vehicle)
);

create table vehicle_reparation
(
    id_vehicle_re int            not null
        primary key,
    amount        decimal(10, 2) not null,
    date          datetime       not null,
    constraint vehicle_reparation_ibfk_1
        foreign key (id_vehicle_re) references vehicle (id_vehicle)
);

create table vehicle_services
(
    id_vehicle_se int            not null
        primary key,
    type          varchar(20)    not null,
    km            int            not null,
    amount        decimal(10, 2) not null,
    start_date    datetime       not null,
    end_date      datetime       not null,
    constraint vehicle_services_ibfk_1
        foreign key (id_vehicle_se) references vehicle (id_vehicle)
);

create table vehicle_spending
(
    id_sp           int auto_increment
        primary key,
    id_vehicle_sp   int            not null,
    id_conductor_sp int            not null,
    date_sp         date           not null,
    time_sp         time           not null,
    type            varchar(20)    not null,
    amount          decimal(10, 2) not null,
    constraint vehicle_spending_ibfk_1
        foreign key (id_vehicle_sp) references vehicle (id_vehicle),
    constraint vehicle_spending_ibfk_2
        foreign key (id_conductor_sp) references conductor (user)
);

create table vehicle_fuel
(
    id_sp_fu int            not null
        primary key,
    quantity decimal(10, 2) not null,
    constraint vehicle_fuel_ibfk_1
        foreign key (id_sp_fu) references vehicle_spending (id_sp)
);

create index id_conductor_sp
    on vehicle_spending (id_conductor_sp);

create index id_vehicle_sp
    on vehicle_spending (id_vehicle_sp);


