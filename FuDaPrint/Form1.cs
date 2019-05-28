﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FuDaPrint
{
    public partial class Form1 : Form
    {

        [DllImport("PrintOut.dll", CharSet = CharSet.Ansi)]
        private static extern bool UsbOut(string PrintName, string OutText);


        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string outText = "~DGE:000.GRF,03584,008,\r\n,::::::::::::::::::O03FE,O0IF80,N03C01E0,N0E0H038,M0180I0C,,:::M01FIF80,:O0703,O0601,O0C0180,::O0E0380,O0707,O03FE,P0F8,,::M01FIF80,:,::P0F8,O03FE,O0707,O0E03,O0C0180,:::O060380,O0707,O03FE,P0F8,,:Q0C,O021F,O063B,O0C3180,O0C7180,:O0C6180,:O07E3,O07C7,O0104,,::::::::P0E4,O03E6,O0767,O0H6380,O0C6180,:::O0E6380,O0767,O03FE,P0F8,,:O01FC,O03FE,O0707,O0E0380,O0C0180,::O0603,O0306,M01FIF80,:,:::::::::P0F8,O03FE,O0707,O0E03,O0C0180,:::O060380,O0707,O03FE,P0F8,,Q0180,O0C0180,:N0JF80,N07FHF,O0C,,:::::::::M01FIF80,:O0703,O0601,O0C0180,::O0E0380,O0707,O03FE,P0F8,,:P0E4,O03E6,O0767,O0H6380,O0C6180,:::O0E6380,O0767,O03FE,P0F8,,O08,O0F,O0FE0,P0FC,P01F80,Q0380,P01F80,O01FC,O0FE0,O0E,O0FC0,O01F8,P03F80,Q0380,Q0F80,P0FC,O07E0,O0F,O08,,P0F8,O03FE,O0707,O0E03,O0C0180,:::O060380,O0707,O03FE,P0F8,,::M01FIF80,:,:::M01FIF80,:,::R080,O07FF80,O07FF,O0E66,O0C63,O0C2180,O0C3180,::O073B80,O031F,Q0E,,::::::::P0E4,O03E6,O0767,O0H6380,O0C6180,:::O0E6380,O0767,O03FE,P0F8,,O0C,::O06,O03FF80,O0IF80,,::R080,O07FF80,O07FF,O0E66,O0C63,O0C2180,O0C3180,::O073B80,O031F,Q0E,,:::::::::M01FIF80,:O0703,O0601,O0C0180,::O0E0380,O0707,O03FE,P0F8,,::O03FF80,O07FF80,O0E,O0C,::O04,O06,O0IF80,:,::R080,O07FF80,O07FF,O0E66,O0C63,O0C2180,O0C3180,::O073B80,O031F,Q0E,,:::::::::O03FF80,O07FF80,O0E,O0C,::O04,O06,O0IF80,:,::P0F8,O03FE,O0707,O0E03,O0C0180,:::O060380,O0707,O03FE,P0F8,,::M018FHF80,:,:Q0180,O0C0180,:N0JF80,N07FHF,O0C,,:Q08,O030E,O070F,O0E0380,O0C0180,::O0E0380,O0707,O03FE,P0F8,,:P0E4,O03E6,O0767,O0H6380,O0C6180,:::O0E6380,O0767,O03FE,P0F8,,:O01FC,O03FE,O0707,O0E0380,O0C0180,::O0603,O0307,O0JFC,:,::Q0C,O021F,O063B,O0C3180,O0C7180,:O0C6180,:O07E3,O07C7,O0104,,::O03FF80,O07FF80,O0E,O0C,::O04,O06,O0IF80,:,:::M018FHF80,:,:::::~DGE:001.GRF,01664,004,\r\n,:::::::::::::::::::I03FF80I07FF80I0E,I0C,::I04,I06,01FIF80:,:::I0JF0I0JF8I070318I06010CI0C018C::I0E038CI070738I03FE38J0F820,::I0IF80:K02,K01,K0180::K0380I0IF,I0HFE,,::J0F8,I03FE,I0707,I0E03,I0C0180:::I060380I0707,I03FE,J0F8,,I0C,::I06,I03FF80I0IF80,:::I03FF80I07FF80I0E,I0C,::I04,I06,01FIF80:,:K0180I0C0180:H0JF80H07FHF,I0C,,::::::::J0E4,I03E6,I0767,I0H6380I0C6180:::I0E6380I0767,I03FE,J0F8,,::01FIF80:,::I01FC,I03FE,I0707,I0E0380I0C0180::I0603,I0306,01FIF80:,:::018FHF80:,:::I0JF0I0JF8I070318I06010CI0C018C::I0E038CI070738I03FE38J0F820,::018FHF80:,:::01FIF80:,::J0E4,I03E6,I0767,I0H6380I0C6180:::I0E6380I0767,I03FE,J0F8,,::::::::J0E4,I03E6,I0767,I0H6380I0C6180:::I0E6380I0767,I03FE,J0F8,,I0C,::I06,I03FF80I0IF80,::L080I07FF80I07FF,I0E66,I0C63,I0C2180I0C3180::I073B80I031F,K0E,,::::::::K0C,I021F,I063B,I0C3180I0C7180:I0C6180:I07E3,I07C7,I0104,,K0180I0C0180:H0JF80H07FHF,I0C,,:K08,I030E,I070F,I0E0380I0C0180::I0E0380I0707,I03FE,J0F8,,::I0IF80:K02,K01,K0180::K0380I0IF,I0HFE,,:::01FIF80:I0703,I0601,I0C0180::I0E0380I0707,I03FE,J0F8,,:J0F8,I03FE,I0707,I0E03,I0C0180:::I060380I0707,I03FE,J0F8,,I0C,::I06,I03FF80I0IF80,::I01FC,I03FE,I0707,I0E0380I0C0180::I0603,I0307,I0JFC:,:::::::::J0E4,I03E6,I0767,I0H6380I0C6180:::I0E6380I0767,I03FE,J0F8,,::I03FF80I07FF80I0E,I0C,::I04,I06,01FIF80:,:0180,:::::01FIF80:0180,:::::,010J0401C0H01CH07800F0H01FHFC0I07FF,,:::::::::::::::::::::::~DGE:002.GRF,02816,008,\r\n,:::::::H030,H020,H030,H010,:::::::::::::H01FFE,H03FHFE0,K03F8,L01C,M06,,::::K01,I0403FE,I0HF3FE,I0HF804,J01004,:::H0201004,H03FIFC,H07FIFC,J01004,:::I041004,I07F204,I0HF3FC,J013FC,M04,,::::J020,J070,:H03038,H0702C,H03020,H03820,H02820,H02CA0,H027FHF8,H023FHFE,H0233FFE,H0I2H06,H0262004,H0242004,H0202004,H02020,::J020,::,:::I040118,I0C4318,I0C4308,I046108,I042108,H03C2108,H03FIF8,H0H7IF8,H0H42108,H0242108,H0642108,H07FIFE,H03FIFE,I07FHFE,I01C0,H01060,I02B8,J0F8,I0E7E,H01E1FF8,H03807F8,H02002,K02,,::::::::L018,L03E,L03F,L031,M01,,:K04,:K06,I0807,I0C0FFE,I0F0DFE,I0F9904,I09F104,I08F104,H049F104,H07F9904,H07E0DFE,I0E05FE,I0307FE,I0382,I021D,I0H39,H0413180,H07FIFE,:I013E,I0107,I010180,I01,,:J020,:J060,::J0E3,I01E3FE,:I0H3104,I061104,H03C1104,H0701104,H0781104,H03C1104,I0E1104,I071104,I0191FE,J0D3FE,:J060,J030,J010,:,:::J04004,J0H404,J0E606,I01EFC2,I03E3F2,I06207A,H06420E2,H07023E2,H07C2782,H01E2462,I07A1F2,I01E7F2,J0H602,H0100F82,H03E1FF8,H03FF9FC,H013F88E,H0100886,H0170884,H017F8C4,H0H1FC44,H0100840,L040,,:J080,J08006,J0C006,I01CC06,I01BF82,I0367F2,I06203A,H01C2002,H07821E2,:H07C2002,I0F2072,I03A1F2,I01A3C2,I026002,I023802,I0H3802,H04130,H07FIFE,:I013E,I0106,I010080,I01,,:M04,J0300C,J0320C,J07604,H0306604,H038C204,H03C8204,H01F8204,H01303FC,H0H183FC,H010C204,H0106204,H0103204,H0121224,H0171A24,I03CA34,H020E314,H0307110,H0385910,H01E4D18,I074798,I01E388,J0E108,J040,,:::K07FC,K0HFC,K07FC,K0408,H03FE408,H07FE408,H0204408,H02047FC,H0204FFE,H02040,:H02047FC,H0204FFC,H02047FC,H03FE408,:K0408,:K07FE,:,::::I0C30,I0820,I0C30,I0410,:I0710,I0790,:I04B0,H01410,H03C10,H07C10,H0H4D0,I05D0,I07D0,I0610,I0410,:I043FE0,I043FF8,I04003C,I040H06,,::L040,I020040,I0600C0,I0601C0,I020180,I0203C0,I0207C0,I021CC0,I023840,I026040,H043C040,H07FIFE,H07FJF,I03F040,I02F040,I023C40,I020E40,I020740,I0203C0,I0200C0,I020040,I020020,I020030,L010,,::::::::::::::::::::~DGE:003.GRF,00768,008,\r\n,:::K03FE,K0IF80,J03800E0,J060H030,,::L0E4,K03E6,K0363,K0H63,:::K0366,K03FE,L0FC,,:J07FHF,:K0104,K0202,K0603,:K0707,K038E,K01FC,,:L0F8,K03FE,K0306,K0603,:::K0306,K03FE,L0F8,,:L018,J01C1C,J0380E,J07007,J06003,::::J03006,J0180E,K0HF8,K03E0,,:J040H010,J030H060,J01E03C0,K07FF,L070,,:::::::::::::::::::::::::::::~DGE:004.GRF,00768,004,\r\n,::::::::::::I07FC,H01FHF,H07001C0H0C0H060,::I01C8,I07CC,I06C6,I0HC6,:::I06CC,I07FC,I01F8,,K02,I0C06,H07FFE,H07FFC,I0C,,:K06,I07FE,I0EDC,I0IC,I0HC6,I0C46,I0C66,:I067E,I023C,,:I07C0,H03FF8,H0701C,H0600C,H0C006,::::::H0IFE,,::::::::I0HFE,I0IFC0I020CC0I040660I0C0660:I0E0E60I071CE0I03F8C0,:I03FE,I07FE,I0E,I0C,::I06,I0HFE,:,::H0CFFE,,::I0806,I0C1E,I0638,I03E0,I01C0,J0C0,H0IFE,:,:J010,I031C,I060E,I0C06,::I0E0E,I07FC,I01F0,,:I01C8,I07CC,I06C6,I0HC6,:::I06CC,I07FC,I01F8,,:I01FE,I07FE,I0E,I0C,:I04,I02,H0IFE,:,:J030,H03838,H0701C,H0E00E,H0C006,::::H0600C,H0301C,H01FF0,I07C0,,:H080H020H060H0C0H03C0780I0HFE,J0E0,,:::::::::::::::::::::::::::::~DGE:005.GRF,00768,008,\r\n,:::::::::::::::::K01FF,K07FFC0,J01C0070,J030H018,,::M0E,K019F,K039980,K0H3980,:K0H3180,:K01F3,L0E2,,:M04,L0C7,K018380,K030180,::K038380,K01FF,L07C,,:K07,J01FC0,J038C0,J03060,::::::J03FHF80,,::J020I08,J0180030,K0F01E0,K03FF80,L038,,:::::::::::::::::::::::::::::~DGE:006.GRF,01024,008,\r\n,:::::::::::::::::::::::M0180C0,::,::::::N060,N07FE0,L0E07FE0,L0HFE0F0,L0HFE230,L081E230,L0806220,L08062,L08C62,L09FE2,:L08062,L08002,L0C0,L0C3FF80,::L0F302,L0HF02,L0JFC0,L0CFHFC0,L0C3E0,L0C0E0,N040,,::::::::::::::::N0IF0,L07CFHF0,:L04CC470,L04CFFC0,:K03CHCH40,K03CCFFC0,:L04CC4,L04CFHF0,L07FIF0,:L04BFE,M081F,M0E1D80,K010F1980,K01C3D980,K01F2F8C0,L07E78C0,L01E1CE0,M060C60,P040,,:::::::::::::::::::::::::::::~DGE:007.GRF,01280,008,\r\n,:::::::::::::::::L02010,L07038,:L02010,,::::::J030,J03FIFE,:J0108206,J0108204,:J01082,J03FHFC0,J03FIF0,K040138,K0C031C,J02C0336,J07FHF72,J07FHF40,K0489,K048940,J0248960,J07FHF70,J07FHF38,K04011C,K040106,K040102,,::::::J03FIFC,::J0101008,:::::::::J03FIFC,J03FIFE,:,::::::L04004,L0H404,L0E606,K01EFC2,K03E3F2,K06207A,J06420E2,J07023E2,J07C2782,J01E2462,K07A1F2,K01E7F2,L0H602,J0100F82,J03E1FF8,J03FF9FC,J013F88E,J0100886,J0170884,J017F8C4,J0H1FC44,J0100840,N040,,:L080,L08006,L0C006,K01CC06,K01BF82,K0367F2,K06203A,J01C2002,J07821E2,:J07C2002,K0F2072,K03A1F2,K01A3C2,K026002,K023802,K0H3802,J04130,J07FIFE,:K013E,K0106,K010080,K01,,:::::::::::::::::::::::::::::~DGE:008.GRF,01024,008,\r\n,:::::::J07FC0,I01FHF0,I07001C,I0C0H06,,:J0C0,::J060,J0HFE0,,::J01C80,J07CC0,J06C60,J0HC60,:::J06CC0,J07FC0,J01F80,,:J08060,J0C1E0,J06380,J03E,J01C,K0C,I0IFE0,:,:K01,J031C0,J060E0,J0C060,::J0E0E0,J07FC0,J01F,,:J01C80,J07CC0,J06C60,J0HC60,:::J06CC0,J07FC0,J01F80,,:J01FE0,J07FE0,J0E0,J0C0,:J040,J020,I0IFE0,:,:K03,I038380,I0701C0,I0E00E0,I0C0060,::::I0600C0,I0301C0,I01FF,J07C,,:I080H02,I060H0C,I03C078,J0HFE0,K0E,,:::::::::::::::::::::::::::::~DGE:009.GRF,01024,008,\r\n,:::::::::::M0201,M070380,:M0201,,::::::::M0200E0,M07FCE0,K0217FCC0,K07F20180,K03F20180,K0I201,K0I203,K0I282,K0I2FA,K0H23FE,K0I21F,K0I20380,K0I2H0C0,K03F20040,K07F3FC60,M03FC20,:P030,P010,:,:::M040040,M0H4040,M0E6060,L01EFC20,L03E3F20,L06207A0,K06420E20,K07023E20,K07C27820,K01E24620,L07A1F20,L01E7F20,M0H6020,K0100F820,K03E1FF80,K03FF9FC0,K013F88E0,K01008860,K01708840,K017F8C40,K0H1FC440,K010084,O04,,:M08,M080060,M0C0060,L01CC060,L01BF820,L0367F20,L06203A0,K01C20020,K07821E20,:K07C20020,L0F20720,L03A1F20,L01A3C20,L0260020,L0238020,L0H38020,K0413,K07FIFE0,:L013E0,L01060,L01008,L010,,:::::::::::::::::::::::::::::~DGE:010.GRF,01280,008,\r\n,:::::::::::::M07FC,L01FHF,L07001C0,L0C0H060,,:O02,M0C06,L07FFE,L07FFC,M0C,,:M01FE,M07FE,M0E,M0C,:M04,M02,L0IFE,:,:M0HFE,M0IFC0,M020CC0,M040660,M0C0660,:M0E0E60,M071CE0,M03F8C0,,::L0CFFE,,::M01C8,M07CC,M06C6,M0HC6,:::M06CC,M07FC,M01F8,,L080,L0F0,L07E,M07E0,N0FC,O0E,N07E,M03F0,L01F80,L0F8,L0C0,L0F8,L01F,M03F0,N03E,O0E,N07E,M07E0,L07F,L0F0,L080,,:::::O02,M0C06,L07FFE,L07FFC,M0C,,:M01C8,M07CC,M06C6,M0HC6,:::M06CC,M07FC,M01F8,,::L0IFE,N01E,N038,N0F0,M01C0,M07,L01E,L038,L0F0,L0IFE,,::L080H020,L060H0C0,L03C0780,M0HFE,N0E0,,:::::::::::::::::::::::::::::~DGE:011.GRF,01024,008,\r\n,:::::::::::::::::::::::O0804,N01C0E,:O0804,,:::::Q01,N08001,N0800180,N0F803,N07FC7,N047FE,L010407C,L01C40FC,L01F53C6,M07F202,N0F801,M08988380,M0C9AC680,M0E58F6C0,M03707C40,L01FFD5C,L01FFDCE,L01E71CA,M0270FB,M075879,M0E4C5180,M08464080,N0424080,,:::::::::::::::::N08002,M019006,M019C03,N0BF81,N0BFF1,M06807D,M0E8005,L01E80F1,L01087F1,N08FF1,N0H801,N08001,M0310C1,M0391C0,M0199C0,N0EB80,L01FJF80,:M01CFE0,M01C8E0,M03C838,M020808,O08,,:::::::::::::::::::::::::::::~DGE:012.GRF,00768,008,\r\n,:::::::::::::P07FC0,O01FHF0,O07001C,O0C0H06,,::P01C80,P07CC0,P06C60,P0HC60,:::P06CC0,P07FC0,P01F80,R060,:P0E060,P0F060,P0D860,P0CE60,P0C760,P0C3E0,P0C0E0,R060,,:O0CFFE0,,::Q07,O030FC0,O0718C0,O0E1860,O0C3860,O0C3060,::O0C70E0,O0H60C0,O03C380,Q03,,:O080H02,O060H0C,O03C078,P0HFE0,Q0E,,:::::::::::::::::::::::::::::~DGE:013.GRF,00512,004,\r\n,:::::::::::::::::::::::::::::::J0HF80I03FFE0I0E0038H0180H0C,::J039,J0F980J0D8C0I0198C0:::J0D980J0HF80J03F,,:J07FC0J0HFC0I0180,::J0C0,J07FC0J0HFC0I0180,::J0C0,I01FFC0:,:L0C0J0HFC0I01DB80I019980I0198C0I0188C0I018CC0:J0CFC0J04780,::H01FHFC0K03C0K07,J01E,J038,J0E0,I03C0,I07,H01E,H01FHFC0,::H010I04I0C0018I0780F0I01FFC0J01C,,:::::::::::::::::::::::::::::~DGE:014.GRF,01024,008,\r\n,:::::::::::::::::::::::P02010,P07038,:P02010,,::::::O040H04,:O060026,N0H24062,N062FF22,:N0H24922,:::N03FIFE,:N0124922,:::N012FF22,:N0120022,:O020H02,:,::::::::::::::::P010,:P030,O01FF80,O09FF80,N01889,N01C89,O0E89,O0EFHFC,N068FHFE,N0688906,N0788906,N01C8904,O0C8904,O0389,O0308,O0108,P050,O0E1E,N01E0FFC,N01803FC,N030011C,Q01,,::::::::::::::::::::::::::::::~DGE:015.GRF,01024,008,\r\n,:::::::::::::::::::::::M0804,L01C0E,:M0804,,::::::K018038,K01C078,K01C0F0,L09180,L083,L0A2,L0BFHF80,J018BFHF80,J01E820180,J01F8301,K03C3C1,L0F0F0,L03038,K082388,K086780,K0C26,K0KF80,K07FIF80,K043F80,K0623C0,K0H20E0,K0H2030,L02008,,:::::::::::::::::N080,K0100FF,K0300FF80,K038081,K03E081,K01F081,K013881,K0H1H81,K010C81,K010681,K090381,J01D3B81,J01F39FF80,K07E0FF80,K01C0C0,L0E060,L03020,L01830,M0810,N018,O08,,::::::::::::::::::::::::::::::~DGE:016.GRF,00512,004,\r\n,:::::::::::::::::::::::J08040I01C0E0:J08040,::::::J0C0,J080,:J04C,01FE4F8001FE4FF0H0FE44F8H0824418::H0824410:H08244,H08264,H0827C,H0FE7C,H0FE48,H0FE40,J040,:::,::::::::::::::::L020I060070:I070010I018010H080C010H0KF0:I030180I030080I0300C0H0810060H0KF0:H01880,:I0840,018840,01FJF001FJF8I083018I083010I081810I0810,,:::::::::::::::::::::::::::::~DGE:017.GRF,01280,008,\r\n,:::::::::::::::::::N01FF0,N07FFC,M01C007,M030H0180,,:::P018,:,::O07C0,N01FF0,N01830,N03018,:::N01830,N01FF0,O07C0,,::M03FHF8,P078,P0E0,O03C0,O07,N01C,N078,N0E0,M03C0,M03FHF8,,::::::::::::::O07F8,N01FF8,N038,N030,:N010,O08,M03FHF8,:,:P040,O0C70,N01838,N03018,::N03838,N01FF0,O07C0,,Q08,N03018,M01FHF8,M01FHF0,N030,,:P018,N01FF8,N03B70,N0I30,N0H318,N03118,N03198,:N019F8,O08F0,,:O01C0,N0F3F0,M01FE30,M030C18,::::::M03FHF8,,::M020I080,M018003,N0F01E,N03FF8,O0380,,:::::::::::::::::::::::::::::~DGE:018.GRF,01024,008,\r\n,:::::::::::::::::::::::K0201,K070380,:K0201,,:::::L040,:L060,J08070,J0C0FFE0,J0F0DFE0,J0F99040,J09F1040,J08F1040,I049F1040,I07F99040,I07E0DFE0,J0E05FE0,J0307FE0,J03820,J021D0,J0H390,I041318,I07FIFE0,:J013E0,J01070,J01018,J010,,:::::::::::::::N040,I010I0C0,I03FFC0C0,I03FFE040,I01004040,I0100FFC0,I0120FFC0,I013FF8,I013FFC,I01001F,I01FFE380,I01FFE180,I01FFE0C0,J0310660,J0210E20,J0318C20,J0109820,I07FHF0,I07FHFE,J0109F,J0108180,J01080C0,J0108020,L08020,,:::::::::::::::::::::::::::::~DGE:019.GRF,00640,004,\r\n,:::I01FF,I07FFC0H01C0070H030H018,:::K0180:,::J07C,I01FF,I0183,I030180:::I0183,I01FF,J07C,,::H03FHF80K0780K0E,J03C,J070,I01C0,I0780,I0E,H03C,H03FHF80,::::::::I03FF80I03FHF0J08330I010198I030198:I038398I01C738J0FE30,:J0HF80I01FF80I0380,I03,::I0180,I03FF80:,::H0H3HF80,:I02,I03C0,J0F8,K0F80K0380J03F,I01F0,I0380,I01F0,J03F,K0380K0F80J0FC,I03E0,I02,,K0180I01FF80I03B7,I0I3,I0H3180I031180I031980:I019F80J08F,,I03,::I0180,I03FF80,::I01F0,I0HFE,H01C07,H01803,H0300180::::::H03FHF80,::H020I08H0180030I0F01E0I03FF80J038,,:::::::::::::::::::::::::::::~DGE:020.GRF,01024,008,\r\n,:::::::::::::::::::::::N08040,M01C0E0,:N08040,,::::::N0C0,N080,:N04C,K01FE4F80,K01FE4FF0,L0FE44F8,L0824418,::L0824410,:L08244,L08264,L0827C,L0FE7C,L0FE48,L0FE40,N040,:::,::::::::::::::::Q08,P018,K01FFE018,K01FHF918,K01FHF908,N01908,L03F9108,L07F9108,L07F8108,M040108,L0HC0508,L0C607F8,L0C60FF8,L07FF908,:L0420108,:L07F8108,L07FE108,L0427108,L0421908,L0420C08,M020408,,::::::::::::::::::::::::::::::~DGE:021.GRF,00640,004,\r\n,::::::::::::::::::::::::::H01FF0,H07FFC,01C007,030H0180,:::J018,:,::I07C0,H01FF0,H01830,H03018,:::H01830,H01FF0,I07C0,,::03FHF8,J078,J0E0,I03C0,I07,H01C,H078,H0E0,03C0,03FHF8,,:::::::H030,::H018,H03FF8,,::I0720,H01F30,H01B18,H0H318,:::H01B30,H01FF0,I07E0,,:03FHF8,:I0820,H01010,H03018,:H03838,H01C70,I0FE0,,H030,::H018,H03FF8,,::H01F,H07FC0,H0E0E0,018030,038038,030018,:::038038,018030,H0C060,H07FC0,H01F,,:020I080018003,H0F01E,H03FF8,I0380,,:::::::::::::::::::::::::::::~DGE:022.GRF,01024,008,\r\n,:::::::::::::::::::::::M0804,L01C0E,:M0804,,::::::M0C,M08,:M04C0,J01FE4F8,J01FE4FF,K0FE44F80,K08244180,::K082441,:K082440,K082640,K0827C0,K0FE7C0,K0FE480,K0FE4,M04,:::,::::::::::::::::::J01FJF80,:K0KF80,K080101,K080301,K090301,K0B830D,K09C64D,K09E6D9,K093D99,K091D91,K0D3D11,K0F8611,K0F8211,K08C301,K080181,K080081,K0KF80,J01FJF80,J01C0H0380,,:::::::::::::::::::::::::::::::~DGE:023.GRF,01024,008,\r\n,::::::::J01FF0,J07FFC,I01C007,I030H0180,,:::L018,:,::K07C0,J01FF0,J01830,J03018,:::J01830,J01FF0,K07C0,,::I03FHF8,L078,L0E0,K03C0,K07,J01C,J078,J0E0,I03C0,I03FHF8,,:::::::M08,J03018,I01FHF8,I01FHF0,J030,,J030,::J018,J03FF8,,::L018,J01FF8,J03B70,J0I30,J0H318,J03118,J03198,:J019F8,K08F0,,:J070,I01FC,I038C,I0306,::::::I03FHF8,,::I020I080,I018003,J0F01E,J03FF8,K0380,,:::::::::::::::::::::::::::::~DGE:024.GRF,01024,008,\r\n,:::::::::::L04020,L0E070,:L04020,,::::::L060,L040,:L026,J0HF27C0,J0HF27F8,J07F227C,J041220C,::J0412208,:J04122,J04132,J0413E,J07F3E,J07F24,J07F20,L020,:::,:::M01,:M0180,K0HFC80,:K048H80,J0C48H80,J0E48H80,J0348H80,K0C8H80,K07FHFC,:J0248H80,J0748H80,J0F48H80,J0C48H80,J0848H80,K0HFC80,K0HFE80,N080,:::,::J030,::J010,::J01FIFC,:J010I0C,J010I08,::J01002,J01003,J01001C0,N0E0,J039FHF0,J079FHF0,J0608030,J04080,L080,:,::::::::::::::::::::::::::::::~DGE:025.GRF,02176,004,\r\n,::::::::::::::::H080,::::::::::::::::::::::::::::::::::,:::H080,::::::::::::::::::::::::::::::::::,:::H080,::::::::::::::::::::::::::::::::::,:::H080,::::::::::::::::::::::::::::::::::,:::H080,::::::::::::::::::::::::::::::::::,:::H080,::::::::::::::::::::::::::::::::::,:::H080,::::::::::::::::::::::::::::::::::,:::H080,::::::::::::::::::::::::::::::::::,:::H080,::::::::::::::::::::::::::::::::::,:::H080,::::::::::::::::::::::::::::::::::,:::H080,::::::::::::::::::::::::::::::::::,:::H080,::::::::::::::::::::::::::::::::::,:::H080,::::::::::::::::::::::::::::::::::,:::::::::::::::::::::::~DGE:026.GRF,02176,004,\r\n,::::::02,::::::::::::::::::::::::::::::::,:::02,::::::::::::::::::::::::::::::::,:::02,::::::::::::::::::::::::::::::::,:::02,::::::::::::::::::::::::::::::::,:::02,::::::::::::::::::::::::::::::::,:::02,::::::::::::::::::::::::::::::::,:::02,::::::::::::::::::::::::::::::::,:::02,::::::::::::::::::::::::::::::::,:::02,::::::::::::::::::::::::::::::::,:::02,::::::::::::::::::::::::::::::::,:::02,::::::::::::::::::::::::::::::::,:::02,::::::::::::::::::::::::::::::::,:::02,::::::::::::::::::::::::::::::::,:::02,::::::::::::::::::::::::::::::::,::::::::::::::::::::::~DGE:027.GRF,02816,008,\r\n,:::::::::::::::::::M04,M0C,L01E,L03F,L07F,L0FE,K01FC,K07FF80,J01FKFE,J0HFCFJF80,I0IF0FJFC0,H01FFE0FJFC0,H01FF00E0H0FE0,H01F800E0H03E0,I0C0H0E0H01E0,M0E0H01E0,:I040H0E0H0180,I07800FFE,I0FE00FHFC0,I0HF80FIF8,I0IF0FIFC,I01FF8E03FF,J07FEE007F80,K0HFE001FC0,K03FC0H0FE0,K01FE0H03E0,L07F8001E0,H010H03F8001C0,H01C0H0F80H0C0,H03F0H07,H03FC002,H03FNFE0,:I07FMFE0,J0NFE0,J03FLFE0,K07F8,K01FC,L0HF,L03F,L01E,M04,,:::Q01,K01C0I03,K01C0I03C0,:K01C70H03C0,K01C7E007C0,I0E07C7F80780,I0IFC7FE0780,I0IFC7FF8F,I0IF873FCF,I0HFE0707FE,I0E0H0703FE,I0E0H0700FC,:I0E0H0703FE,I0E0H070FHF,I0HFC077FCF,I0IF07FF0780,I0IF87FE07C0,I0IFC7F003C0,K07E7C003E0,K01E70H01E0,L0C0I01C0,L080J080,I0NFE,I0OF80,:I0OFC0,I0E0380E007C0,I0E0380E003C0,::I0E0380E003,I0E0380E0,I0LFC,I0MFE0,I0NFE,I0OF80,N01FHFC0,P03FC0,Q0780,Q0180,,::::Q02,Q0380,K070H0103C0,K070H0303C0,K070H0783C0,K07001F81C0,K07003F81C0,K07007F01C0,K0700FE01C0,K0701FC01C0,K0707F801C0,K0707E001C0,K0707C001C0,H01007038001C0,H01FHFC10H01C0,H01FIFC0H01C0,H03FJFI01C0,H03FJFC001C0,K07FFE001C0,K070FF801C0,K0703FC03C0,K0700FE03C0,K07003F03C0,K07001F8380,K070H0FC380,K070H07C780,:K070H0387,K070H010F,Q0F,P01E,J060J03C,I01F03FIF8,I07F03FIF8,I0HF03FIF8,H01FE03FIFC,H01F8038003F,I0E0038001F80,I0400380H0FC0,L0380H0780,L0380H0380,L0380H01,,::::::I0E0I0JFE0,::I0E1FF0FIFE0,I0E1FF0C1C180,::I0E1830C1C180,::I0E1830FIF80,:::I0E1830C1C180,:::I0E1FF0C1C180,:I0E1FF0FJF0,:I0E0I0KF0,:I0E0I018,N018,J010H07C,J01E00FC,J01FC1F8,I039FF1F0,I0F9FFCE0H020,H01FDDFKFE0,H01FDC7FJFE0,H01F1C1FJFE0,I0C1C07FIFE0,J01C03F0,J01C00F8,J01C007E,J01C003E,J01C001E,O08,,::Q04,K0FE0H01C,J03FF8007C,J07FFC01FC,J07FFC07FC,J0IFE1FFC,J0F83E7FF0,I01F00FHF80,I01E00FFE,I01C007F8,I01C007E0,I01C00780,I01C007,:::I01FLFC,::::,::P01C,P0FC,O0HFC,N07FFC,M07FHFC,L03FHFE0,K01FHFE,J01FIF0,J0JF70,I01FHF070,I01FF8070,:I01FHF870,J0KF0,K0JF0,K01FIF,L01FIF0,M03FHFC,N07FFC,O07FC,P0FC,Q0C,,::L0IF8,K07FIF,J01FJFC0,J03FJFE0,J07FKF0,J07F0H07F0,J0FC0H01F8,J0F0J078,I01E0J038,I01E0J03C,I01C0J01C,::::I01FLFC,::::,:::K01FHFE,K0KFC0,J03FKF0,J07FKF8,J0MFC,J0FE0H01FC,I01F0J03E,I01E0J01E,I01C0K0E,::I01C0J01E,I01E0J01E,I01F0J03E,J0FE0H01FC,J0MFC,J07FKF8,J03FKF0,K0KFC0,K03FHFE,,:::K01FHFE,K0KFC0,J03FKF0,J07FKF8,J0MFC,J0FE0H01FC,I01F0J03E,I01E0J01E,I01C0K0E,::I01C0J01E,I01E0J01E,I01F0J03E,J0FE0H01FC,J0MFC,J07FKF8,J03FKF0,K0KFC0,K03FHFE,,:::I01C0,::I01C007,:::::::::::I01FLFC,::::,:::~DGE:028.GRF,01280,008,\r\n,:::::::::::::::::::::::::::::::S01C0L0180J01C0L01800E001C0::::::::L01FLFC0:::L0180J01C0::L018020H01C0L01803FIFC0:::L0180J01C0:R031C0R079C0M040I07E,M0E0I07F,L01F07FIF80L03F07FIFC0L07E07FIFE0L07807FIFE0L070060H01C0L02006,O06,:::,:::P030,P03C,:M08003C,M0E003BFHF0M0FC07BFHF0M0FE07BFHF0M0HF8F3FHF0M0DFCF30180M0C3FE30180M0C1FE30180M0C07C30180M0C0FC30180L0HC1FE30180L0EC3FE30180L0FCFCF30180K01FHF8730180L0HFE07BFHF0L01FC03BFHF0M07F03FIF0M01F83FIF0N0FC1E,N0381E,N0181E,M01C0EC,M01C3E8,M01C3E0,M01C3C0,K01FNF0:::M01FHF8,M01C7FC,M01C0FE,M01C03F80,M01C01F80,M01C007,Q02,,:::O04,O0E,O0F80,O0F,:N01F,N01E,N03E03FHF8N03C03FHF8N07C03FHF8N07F03FHF8N0F70301C0M01F70301C0M03E70301C0M07C70301C0M0F870301C0L01F070301C0L0BE070301C0L0FC070301C0K01F8070301C0:K01FC070301C0L0FE070301C0L03F070301C0L01F870301C0M07C70301C0M03E70301C0M01F70301C0N0HF0301C0N07F03FHF8N03C03FHF8N03E03FHF8N01E03FHF8O0F,O0F80,O0780,:O03,:,::\r\n^XA^LL0591\r\n^PW1063\r\n^FT832,512^XGE:000.GRF,1,1^FS\r\n^FT832,512^XGE:001.GRF,1,1^FS\r\n^FT800,480^XGE:002.GRF,1,1^FS\r\n^FT160,576^XGE:003.GRF,1,1^FS\r\n^FT576,576^XGE:004.GRF,1,1^FS\r\n^FT448,576^XGE:005.GRF,1,1^FS\r\n^FT128,576^XGE:006.GRF,1,1^FS\r\n^FT544,576^XGE:007.GRF,1,1^FS\r\n^FT512,576^XGE:008.GRF,1,1^FS\r\n^FT480,576^XGE:009.GRF,1,1^FS\r\n^FT384,576^XGE:010.GRF,1,1^FS\r\n^FT416,576^XGE:011.GRF,1,1^FS\r\n^FT256,576^XGE:012.GRF,1,1^FS\r\n^FT224,576^XGE:013.GRF,1,1^FS\r\n^FT352,576^XGE:014.GRF,1,1^FS\r\n^FT192,576^XGE:015.GRF,1,1^FS\r\n^FT320,576^XGE:016.GRF,1,1^FS\r\n^FT320,576^XGE:017.GRF,1,1^FS\r\n^FT256,576^XGE:018.GRF,1,1^FS\r\n^FT704,576^XGE:019.GRF,1,1^FS\r\n^FT608,576^XGE:020.GRF,1,1^FS\r\n^FT768,576^XGE:021.GRF,1,1^FS\r\n^FT672,576^XGE:022.GRF,1,1^FS\r\n^FT640,576^XGE:023.GRF,1,1^FS\r\n^FT736,576^XGE:024.GRF,1,1^FS\r\n^FT128,576^XGE:025.GRF,1,1^FS\r\n^FT608,576^XGE:026.GRF,1,1^FS\r\n^FT32,448^XGE:027.GRF,1,1^FS\r\n^FT64,352^XGE:028.GRF,1,1^FS\r\n^PQ1,0,1,Y^XZ";
            UsbOut(this.txtIP.Text, outText);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
