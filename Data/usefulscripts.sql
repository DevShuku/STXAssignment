use stxassignmentdbfinal;
select * from stxassignmentdbfinal.tradedetails

INSERT INTO stxassignmentdbfinal.customer (
CustomerId, CustomerName, Type, ContactId, Contact, Country) values
(1,	'ABC Wholesalers', 'Wholesaler', '01',	'John Smith','UAE'),
(2,'XYZ Retail Chain','Retailer','02',	'Shreshta',	'INDIA'),
(3,	'Global Import Ltd','Importer',	'03','David Lee', 'UK');

INSERT INTO stxassignmentdbfinal.suplier (SupplierId, SupplierName, Category, ContactName, Country) values
('1', 'ABC Electronics Co.', 'Electronics', 'Michael Chang', 'UAE'),
('2', 'XYZ Textiles Ltd.', 'Textiles', 'Shreshta', 'INDIA'),
('3', 'Global Import Ltd', 'Importer', 'David Lee', 'UK')

INSERT INTO stxassignmentdbfinal.tradedetails (TradeId, TradeName, TradeDate, ContractDetail, ProductDetail, ShippingDetail, Status) values
('TR-22-00002','XYZ trading',DATE("2023-05-15"),'SMJ Power Ltd','12345 COAL','Sea','CustomerContract'),
('TR-22-00003','ABC trading',DATE("2023-05-15"),'OOJ Power Ltd','12345 COAL','Sea','CustomerContract'),
('TR-22-00004','yyZ trading',DATE("2023-05-15"),'SoJ Power Ltd','12345 COAL','Sea','SupplierContract'),
('TR-22-00005','XYZ trading',DATE("2023-05-15"),'SMJ Power Ltd','12345 COAL','Sea','EstimatedCostSheet'),
('TR-22-00006','ABC trading',DATE("2023-05-15"),'OOJ Power Ltd','12345 COAL','Sea','EstimatedCostSheet'),
('TR-22-00007','yyZ trading',DATE("2023-05-15"),'SoJ Power Ltd','12345 COAL','Sea','SupplierContract')


INSERT INTO stxassignmentdbfinal.meeting (MeetingId, Date, Time, Participants, Agenda) VALUES
(1, DATE("2023-05-15"), TIME("10:30:00"),'Paul' ,'Discuss new product line collaboration'),
(2, DATE("2024-03-15"), TIME("12:30:00"),'Shruthi' ,'Review quarterly performance and plan for upcoming logistics improvements'),
(3, DATE("2024-06-15"), TIME("17:00:00"), 'George','Review quarterly performance and plan for upcoming logistics improvements');