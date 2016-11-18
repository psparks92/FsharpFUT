namespace FSharpCalc
open FSharpCalc
module Formations =

    // let formation3142 = {
    //     Name= "3-4-1-2";
    //     Positions= [
    //                 {
    //                 Index = 0;
    //                 Name= "GK";
    //                 Links = [|1;2;3;|];
    //                 Position= GK
    //                 };
    //                 {
    //                 Index = 1;
    //                 Name= "LCB";
    //                 Links = [|0;2;4;|];
    //                 Position= CB
    //                 };
    //                 {
    //                 Index = 2;
    //                 Name= "CB";
    //                 Links = [|1;0;3;5;7|];
    //                 Position= CB
    //                 };
    //                 {
    //                 Index = 3;
    //                 Name= "RCB";
    //                 Links = [|0;2;8;|];
    //                 Position= CB
    //                 };
    //                 {
    //                 Index = 4;
    //                 Name= "LM";
    //                 Links = [|1;5;9;|];
    //                 Position= LM
    //                 };
    //                 {
    //                 Index = 5;
    //                 Name= "LCM";
    //                 Links = [|2;4;7;6|];
    //                 Position= CM
    //                 };
    //                 {
    //                 Index = 6;
    //                 Name= "CAM";
    //                 Links = [|5;7;9;10|];
    //                 Position= CAM
    //                 };
    //                 {
    //                 Index = 7;
    //                 Name= "RCM";
    //                 Links = [|2;8;5;6|];
    //                 Position= CM
    //                 };
    //                 {
    //                 Index = 8;
    //                 Name= "RM";
    //                 Links = [|3;7;10|];
    //                 Position= RM
    //                 };
    //                 {
    //                 Index = 9;
    //                 Name= "LST";
    //                 Links = [|4;6;10;|];
    //                 Position= ST
    //                 };
    //                 {
    //                 Index = 10;
    //                 Name= "RST";
    //                 Links = [|8;6;9;|];
    //                 Position= ST
    //                 }
    //     ]
    // }
    //

    let formation3421 = {
        Name = "3421";
        Positions = [
                    {
                        Name = "CB";
                        Index = 2
                        Links = [|"GK";"LCB";"RCB";"LCM";"RCM"|];
                        Position = CB
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"CB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LCB";
                        Index = 1
                        Links = [|"GK";"CB";"LM"|];
                        Position = CB
            };
                    {
                        Name = "LCM";
                        Index = 5
                        Links = [|"CB";"LM";"RCM";"LF"|];
                        Position = CM
            };
                    {
                        Name = "LF";
                        Index = 8
                        Links = [|"LM";"LCM";"ST"|];
                        Position = LF
            };
                    {
                        Name = "LM";
                        Index = 4
                        Links = [|"LCB";"LCM";"LF"|];
                        Position = LM
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"CB";"RM"|];
                        Position = CB
            };
                    {
                        Name = "RCM";
                        Index = 6
                        Links = [|"CB";"RM";"LCM";"RF"|];
                        Position = CM
            };
                    {
                        Name = "RF";
                        Index = 10
                        Links = [|"RM";"RCM";"ST"|];
                        Position = RF
            };
                    {
                        Name = "RM";
                        Index = 7
                        Links = [|"RCB";"RCM";"RF"|];
                        Position = RM
            };
                    {
                        Name = "ST";
                        Index = 9
                        Links = [|"LF";"RF"|];
                        Position = ST
            }
        ];
    };
    let formation343 = {
        Name = "343";
        Positions = [
                    {
                        Name = "CB";
                        Index = 2
                        Links = [|"GK";"LCB";"RCB";"LCM";"RCM"|];
                        Position = CB
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"CB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LCB";
                        Index = 1
                        Links = [|"GK";"CB";"LM"|];
                        Position = CB
            };
                    {
                        Name = "LCM";
                        Index = 5
                        Links = [|"CB";"LM";"RCM";"ST"|];
                        Position = CM
            };
                    {
                        Name = "LM";
                        Index = 4
                        Links = [|"LCB";"LCM";"LW"|];
                        Position = LM
            };
                    {
                        Name = "LW";
                        Index = 8
                        Links = [|"LM";"ST"|];
                        Position = LW
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"CB";"RM"|];
                        Position = CB
            };
                    {
                        Name = "RCM";
                        Index = 6
                        Links = [|"CB";"RM";"LCM";"ST"|];
                        Position = CM
            };
                    {
                        Name = "RM";
                        Index = 7
                        Links = [|"RCB";"RCM";"RW"|];
                        Position = RM
            };
                    {
                        Name = "RW";
                        Index = 10
                        Links = [|"RM";"ST"|];
                        Position = RW
            };
                    {
                        Name = "ST";
                        Index = 9
                        Links = [|"LCM";"RCM";"LW";"RW"|];
                        Position = ST
            }
        ];
    };
    let formation352 = {
        Name = "352";
        Positions = [
                    {
                        Name = "CAM";
                        Index = 6
                        Links = [|"LCDM";"RCDM";"LST";"RST"|];
                        Position = CAM
            };
                    {
                        Name = "CB";
                        Index = 2
                        Links = [|"GK";"LCB";"RCB";"LCDM";"RCDM"|];
                        Position = CB
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"CB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LCB";
                        Index = 1
                        Links = [|"GK";"CB";"LM";"LCDM"|];
                        Position = CB
            };
                    {
                        Name = "LCDM";
                        Index = 5
                        Links = [|"LCB";"CB";"LM";"RCDM";"CAM"|];
                        Position = CDM
            };
                    {
                        Name = "LM";
                        Index = 4
                        Links = [|"LCB";"LCDM";"LST"|];
                        Position = LM
            };
                    {
                        Name = "LST";
                        Index = 9
                        Links = [|"LM";"CAM";"RST"|];
                        Position = ST
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"CB";"RCDM";"RM"|];
                        Position = CB
            };
                    {
                        Name = "RCDM";
                        Index = 7
                        Links = [|"CB";"RCB";"LCDM";"RM";"CAM"|];
                        Position = CDM
            };
                    {
                        Name = "RM";
                        Index = 8
                        Links = [|"RCB";"RCDM";"RST"|];
                        Position = RM
            };
                    {
                        Name = "RST";
                        Index = 10
                        Links = [|"RM";"CAM";"LST"|];
                        Position = ST
            }
        ];
    };
    let formation41212 = {
        Name = "41212";
        Positions = [
                    {
                        Name = "CAM";
                        Index = 7
                        Links = [|"CDM";"LM";"RM";"LST";"RST"|];
                        Position = CAM
            };
                    {
                        Name = "CDM";
                        Index = 6
                        Links = [|"LCB";"RCB";"LM";"RM";"CAM"|];
                        Position = CDM
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LM"|];
                        Position = LB
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"CDM"|];
                        Position = CB
            };
                    {
                        Name = "LM";
                        Index = 5
                        Links = [|"LB";"CDM";"CAM";"LST"|];
                        Position = LM
            };
                    {
                        Name = "LST";
                        Index = 9
                        Links = [|"LM";"CAM";"RST"|];
                        Position = ST
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RM"|];
                        Position = RB
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"CDM"|];
                        Position = CB
            };
                    {
                        Name = "RM";
                        Index = 8
                        Links = [|"RB";"CDM";"CAM";"RST"|];
                        Position = RM
            };
                    {
                        Name = "RST";
                        Index = 10
                        Links = [|"RM";"CAM";"LST"|];
                        Position = ST
            }
        ];
    };
    let formation412122 = {
        Name = "412122";
        Positions = [
                    {
                        Name = "CAM";
                        Index = 7
                        Links = [|"CDM";"LCM";"RCM";"LST";"RST"|];
                        Position = CAM
            };
                    {
                        Name = "CDM";
                        Index = 6
                        Links = [|"LCB";"RCB";"LCM";"RCM";"CAM"|];
                        Position = CDM
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LCM"|];
                        Position = LB
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"CDM"|];
                        Position = CB
            };
                    {
                        Name = "LCM";
                        Index = 5
                        Links = [|"LB";"CDM";"CAM";"LST"|];
                        Position = CM
            };
                    {
                        Name = "LST";
                        Index = 9
                        Links = [|"LCM";"CAM";"RST"|];
                        Position = ST
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RCM"|];
                        Position = RB
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"CDM"|];
                        Position = CB
            };
                    {
                        Name = "RCM";
                        Index = 8
                        Links = [|"RB";"CDM";"CAM";"RST"|];
                        Position = CM
            };
                    {
                        Name = "RST";
                        Index = 10
                        Links = [|"RCM";"CAM";"LST"|];
                        Position = ST
            }
        ];
    };
    let formation4141 = {
        Name = "4141";
        Positions = [
                    {
                        Name = "CDM";
                        Index = 7
                        Links = [|"LCB";"RCB";"LCM";"RCM"|];
                        Position = CDM
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LM"|];
                        Position = LB
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"LCM";"CDM"|];
                        Position = CB
            };
                    {
                        Name = "LCM";
                        Index = 6
                        Links = [|"LCB";"CDM";"LM";"RCM";"ST"|];
                        Position = CM
            };
                    {
                        Name = "LM";
                        Index = 5
                        Links = [|"LB";"LCM";"ST"|];
                        Position = LM
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RM"|];
                        Position = RB
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"CDM";"RCM"|];
                        Position = CB
            };
                    {
                        Name = "RCM";
                        Index = 8
                        Links = [|"RCB";"CDM";"LCM";"RM";"ST"|];
                        Position = CM
            };
                    {
                        Name = "RM";
                        Index = 9
                        Links = [|"RB";"RCM";"ST"|];
                        Position = RM
            };
                    {
                        Name = "ST";
                        Index = 10
                        Links = [|"LM";"LCM";"RCM";"RM"|];
                        Position = ST
            }
        ];
    };
    let formation4222 = {
        Name = "4222";
        Positions = [
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LCAM"|];
                        Position = LB
            };
                    {
                        Name = "LCAM";
                        Index = 5
                        Links = [|"LB";"LCDM";"LST"|];
                        Position = CAM
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"LCDM"|];
                        Position = CB
            };
                    {
                        Name = "LCDM";
                        Index = 6
                        Links = [|"LCB";"RCDM";"LCAM";"LST"|];
                        Position = CDM
            };
                    {
                        Name = "LST";
                        Index = 9
                        Links = [|"LCDM";"LCAM";"RST"|];
                        Position = ST
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RCAM"|];
                        Position = RB
            };
                    {
                        Name = "RCAM";
                        Index = 8
                        Links = [|"RB";"RCDM";"RST"|];
                        Position = CAM
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"RCDM"|];
                        Position = CB
            };
                    {
                        Name = "RCDM";
                        Index = 7
                        Links = [|"RCB";"LCDM";"RCAM";"RST"|];
                        Position = CDM
            };
                    {
                        Name = "RST";
                        Index = 10
                        Links = [|"RCDM";"RCAM";"LST"|];
                        Position = ST
            }
        ];
    };
    let formation4231 = {
        Name = "4231";
        Positions = [
                    {
                        Name = "CAM";
                        Index = 7
                        Links = [|"LCDM";"RCDM";"LCAM";"RCAM";"ST"|];
                        Position = CAM
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LCDM"|];
                        Position = LB
            };
                    {
                        Name = "LCAM";
                        Index = 6
                        Links = [|"LCDM";"CAM";"ST"|];
                        Position = CAM
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"LCDM"|];
                        Position = CB
            };
                    {
                        Name = "LCDM";
                        Index = 5
                        Links = [|"LB";"LCB";"CAM";"LCAM"|];
                        Position = CDM
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RCDM"|];
                        Position = RB
            };
                    {
                        Name = "RCAM";
                        Index = 8
                        Links = [|"RCDM";"CAM";"ST"|];
                        Position = CAM
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"RCDM"|];
                        Position = CB
            };
                    {
                        Name = "RCDM";
                        Index = 9
                        Links = [|"RCB";"RB";"CAM";"RCAM"|];
                        Position = CDM
            };
                    {
                        Name = "ST";
                        Index = 10
                        Links = [|"LCAM";"CAM";"RCAM"|];
                        Position = ST
            }
        ];
    };
    let formation42312 = {
        Name = "42312";
        Positions = [
                    {
                        Name = "CAM";
                        Index = 7
                        Links = [|"LCDM";"RCDM";"LM";"RM";"ST"|];
                        Position = CAM
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LCDM";"LM"|];
                        Position = LB
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"LCDM"|];
                        Position = CB
            };
                    {
                        Name = "LCDM";
                        Index = 6
                        Links = [|"LB";"LCB";"CAM";"LM"|];
                        Position = CDM
            };
                    {
                        Name = "LM";
                        Index = 5
                        Links = [|"LB";"LCDM";"CAM";"ST"|];
                        Position = LM
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RCDM";"RM"|];
                        Position = RB
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"RCDM"|];
                        Position = CB
            };
                    {
                        Name = "RCDM";
                        Index = 8
                        Links = [|"RCB";"RB";"CAM";"RM"|];
                        Position = CDM
            };
                    {
                        Name = "RM";
                        Index = 9
                        Links = [|"RB";"RCDM";"CAM";"ST"|];
                        Position = RM
            };
                    {
                        Name = "ST";
                        Index = 10
                        Links = [|"LM";"CAM";"RM"|];
                        Position = ST
            }
        ];
    };
    let formation4312 = {
        Name = "4312";
        Positions = [
                    {
                        Name = "CAM";
                        Index = 7
                        Links = [|"CM";"LST";"RST"|];
                        Position = CAM
            };
                    {
                        Name = "CM";
                        Index = 6
                        Links = [|"LCB";"RCB";"LCM";"RCM";"CAM"|];
                        Position = CM
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LCM"|];
                        Position = LB
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"LCM";"CM"|];
                        Position = CB
            };
                    {
                        Name = "LCM";
                        Index = 5
                        Links = [|"LB";"LCB";"CM";"LST"|];
                        Position = CM
            };
                    {
                        Name = "LST";
                        Index = 9
                        Links = [|"LCM";"CAM";"RST"|];
                        Position = ST
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RCM"|];
                        Position = RB
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"CM";"RCM"|];
                        Position = CB
            };
                    {
                        Name = "RCM";
                        Index = 8
                        Links = [|"RCB";"RB";"CM";"RST"|];
                        Position = CM
            };
                    {
                        Name = "RST";
                        Index = 10
                        Links = [|"RCM";"CAM";"LST"|];
                        Position = ST
            }
        ];
    };
    let formation4321 = {
        Name = "4321";
        Positions = [
                    {
                        Name = "CM";
                        Index = 6
                        Links = [|"LCM";"RCM";"LF";"RF"|];
                        Position = CM
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LCM"|];
                        Position = LB
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"LCM"|];
                        Position = CB
            };
                    {
                        Name = "LCM";
                        Index = 5
                        Links = [|"LB";"LCB";"CM";"LF"|];
                        Position = CM
            };
                    {
                        Name = "LF";
                        Index = 8
                        Links = [|"LCM";"CM";"ST"|];
                        Position = LF
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RCM"|];
                        Position = RB
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"RCM"|];
                        Position = CB
            };
                    {
                        Name = "RCM";
                        Index = 7
                        Links = [|"RCB";"RB";"CM";"RF"|];
                        Position = CM
            };
                    {
                        Name = "RF";
                        Index = 10
                        Links = [|"CM";"RCM";"ST"|];
                        Position = RF
            };
                    {
                        Name = "ST";
                        Index = 9
                        Links = [|"LF";"RF"|];
                        Position = ST
            }
        ];
    };
    let formation433 = {
        Name = "433";
        Positions = [
                    {
                        Name = "CM";
                        Index = 6
                        Links = [|"LCB";"RCB";"LCM";"RCM";"ST"|];
                        Position = CM
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LCM"|];
                        Position = LB
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"CM"|];
                        Position = CB
            };
                    {
                        Name = "LCM";
                        Index = 5
                        Links = [|"LB";"CM";"LW"|];
                        Position = CM
            };
                    {
                        Name = "LW";
                        Index = 8
                        Links = [|"LCM";"ST"|];
                        Position = LW
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RCM"|];
                        Position = RB
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"CM"|];
                        Position = CB
            };
                    {
                        Name = "RCM";
                        Index = 7
                        Links = [|"RB";"CM";"RW"|];
                        Position = CM
            };
                    {
                        Name = "RW";
                        Index = 10
                        Links = [|"RCM";"ST"|];
                        Position = RW
            };
                    {
                        Name = "ST";
                        Index = 9
                        Links = [|"CM";"LW";"RW"|];
                        Position = ST
            }
        ];
    };
    let formation4332 = {
        Name = "4332";
        Positions = [
                    {
                        Name = "CDM";
                        Index = 6
                        Links = [|"LCB";"RCB";"LCM";"RCM"|];
                        Position = CDM
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LCM"|];
                        Position = LB
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"CDM"|];
                        Position = CB
            };
                    {
                        Name = "LCM";
                        Index = 5
                        Links = [|"LB";"CDM";"RCM";"LW";"ST"|];
                        Position = CM
            };
                    {
                        Name = "LW";
                        Index = 8
                        Links = [|"LCM";"ST"|];
                        Position = LW
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RCM"|];
                        Position = RB
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"CDM"|];
                        Position = CB
            };
                    {
                        Name = "RCM";
                        Index = 7
                        Links = [|"RB";"LCM";"CDM";"ST";"RW"|];
                        Position = CM
            };
                    {
                        Name = "RW";
                        Index = 10
                        Links = [|"RCM";"ST"|];
                        Position = RW
            };
                    {
                        Name = "ST";
                        Index = 9
                        Links = [|"LCM";"RCM";"LW";"RW"|];
                        Position = ST
            }
        ];
    };
    let formation4333 = {
        Name = "4333";
        Positions = [
                    {
                        Name = "CM";
                        Index = 6
                        Links = [|"LCDM";"RCDM";"ST"|];
                        Position = CM
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LCDM"|];
                        Position = LB
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"LCDM"|];
                        Position = CB
            };
                    {
                        Name = "LCDM";
                        Index = 5
                        Links = [|"LB";"LCB";"CM";"LW"|];
                        Position = CDM
            };
                    {
                        Name = "LW";
                        Index = 8
                        Links = [|"LCDM";"ST"|];
                        Position = LW
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RCDM"|];
                        Position = RB
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"RCDM"|];
                        Position = CB
            };
                    {
                        Name = "RCDM";
                        Index = 7
                        Links = [|"RCB";"RB";"CM";"RW"|];
                        Position = CDM
            };
                    {
                        Name = "RW";
                        Index = 10
                        Links = [|"RCDM";"ST"|];
                        Position = RW
            };
                    {
                        Name = "ST";
                        Index = 9
                        Links = [|"CM";"LW";"RW"|];
                        Position = ST
            }
        ];
    };
    let formation4334 = {
        Name = "4334";
        Positions = [
                    {
                        Name = "CAM";
                        Index = 6
                        Links = [|"LCM";"RCM";"ST"|];
                        Position = CAM
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LCM";"LW"|];
                        Position = LB
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"LCM"|];
                        Position = CB
            };
                    {
                        Name = "LCM";
                        Index = 5
                        Links = [|"LB";"LCB";"CAM";"LW"|];
                        Position = CM
            };
                    {
                        Name = "LW";
                        Index = 8
                        Links = [|"LB";"LCM";"ST"|];
                        Position = LW
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RCM";"RW"|];
                        Position = RB
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"RCM"|];
                        Position = CB
            };
                    {
                        Name = "RCM";
                        Index = 7
                        Links = [|"RCB";"RB";"CAM";"RW"|];
                        Position = CM
            };
                    {
                        Name = "RW";
                        Index = 10
                        Links = [|"RB";"RCM";"ST"|];
                        Position = RW
            };
                    {
                        Name = "ST";
                        Index = 9
                        Links = [|"CAM";"LW";"RW"|];
                        Position = ST
            }
        ];
    };
    let formation4335 = {
        Name = "4335";
        Positions = [
                    {
                        Name = "CDM";
                        Index = 6
                        Links = [|"LCB";"RCB";"LCM";"RCM"|];
                        Position = CDM
            };
                    {
                        Name = "CF";
                        Index = 9
                        Links = [|"LCM";"RCM";"LW";"RW"|];
                        Position = CF
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LCM";"LW"|];
                        Position = LB
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"CDM"|];
                        Position = CB
            };
                    {
                        Name = "LCM";
                        Index = 5
                        Links = [|"LB";"CDM";"LW";"CF"|];
                        Position = CM
            };
                    {
                        Name = "LW";
                        Index = 8
                        Links = [|"LB";"LCM";"CF"|];
                        Position = LW
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RCM";"RW"|];
                        Position = RB
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"CDM"|];
                        Position = CB
            };
                    {
                        Name = "RCM";
                        Index = 7
                        Links = [|"RB";"CDM";"CF";"RW"|];
                        Position = CM
            };
                    {
                        Name = "RW";
                        Index = 10
                        Links = [|"RB";"RCM";"CF"|];
                        Position = RW
            }
        ];
    };
    let formation4411 = {
        Name = "4411";
        Positions = [
                    {
                        Name = "CF";
                        Index = 9
                        Links = [|"LCM";"RCM";"ST"|];
                        Position = CF
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LM"|];
                        Position = LB
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"LCM"|];
                        Position = CB
            };
                    {
                        Name = "LCM";
                        Index = 6
                        Links = [|"LCB";"LM";"RCM";"CF"|];
                        Position = CM
            };
                    {
                        Name = "LM";
                        Index = 5
                        Links = [|"LB";"LCM";"ST"|];
                        Position = LM
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RM"|];
                        Position = RB
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"RCM"|];
                        Position = CB
            };
                    {
                        Name = "RCM";
                        Index = 7
                        Links = [|"RCB";"LCM";"RM";"CF"|];
                        Position = CM
            };
                    {
                        Name = "RM";
                        Index = 8
                        Links = [|"RB";"RCM";"ST"|];
                        Position = RM
            };
                    {
                        Name = "ST";
                        Index = 10
                        Links = [|"LM";"RM";"CF"|];
                        Position = ST
            }
        ];
    };
    let formation442 = {
        Name = "442";
        Positions = [
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LM"|];
                        Position = LB
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"LCM"|];
                        Position = CB
            };
                    {
                        Name = "LCM";
                        Index = 6
                        Links = [|"LCB";"LM";"RCM";"LST"|];
                        Position = CM
            };
                    {
                        Name = "LM";
                        Index = 5
                        Links = [|"LB";"LCM";"LST"|];
                        Position = LM
            };
                    {
                        Name = "LST";
                        Index = 9
                        Links = [|"LM";"LCM";"RST"|];
                        Position = ST
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RM"|];
                        Position = RB
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"RCM"|];
                        Position = CB
            };
                    {
                        Name = "RCM";
                        Index = 7
                        Links = [|"RCB";"LCM";"RM";"RST"|];
                        Position = CM
            };
                    {
                        Name = "RM";
                        Index = 8
                        Links = [|"RB";"RCM";"RST"|];
                        Position = RM
            };
                    {
                        Name = "RST";
                        Index = 10
                        Links = [|"RCM";"RM";"LST"|];
                        Position = ST
            }
        ];
    };
    let formation4422 = {
        Name = "4422";
        Positions = [
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LM"|];
                        Position = LB
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"LCDM"|];
                        Position = CB
            };
                    {
                        Name = "LCDM";
                        Index = 6
                        Links = [|"LCB";"LM";"RCDM";"LST"|];
                        Position = CDM
            };
                    {
                        Name = "LM";
                        Index = 5
                        Links = [|"LB";"LCDM";"LST"|];
                        Position = LM
            };
                    {
                        Name = "LST";
                        Index = 9
                        Links = [|"LM";"LCDM";"RST"|];
                        Position = ST
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RM"|];
                        Position = RB
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"RCDM"|];
                        Position = CB
            };
                    {
                        Name = "RCDM";
                        Index = 7
                        Links = [|"RCB";"LCDM";"RM";"RST"|];
                        Position = CDM
            };
                    {
                        Name = "RM";
                        Index = 8
                        Links = [|"RB";"RCDM";"RST"|];
                        Position = RM
            };
                    {
                        Name = "RST";
                        Index = 10
                        Links = [|"RCDM";"RM";"LST"|];
                        Position = ST
            }
        ];
    };
    let formation451 = {
        Name = "451";
        Positions = [
                    {
                        Name = "CM";
                        Index = 7
                        Links = [|"LCB";"RCB";"LCAM";"RCAM"|];
                        Position = CM
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LM"|];
                        Position = LB
            };
                    {
                        Name = "LCAM";
                        Index = 6
                        Links = [|"LM";"CM";"RCAM";"ST"|];
                        Position = CAM
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"CM"|];
                        Position = CB
            };
                    {
                        Name = "LM";
                        Index = 5
                        Links = [|"LB";"LCAM"|];
                        Position = LM
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RM"|];
                        Position = RB
            };
                    {
                        Name = "RCAM";
                        Index = 8
                        Links = [|"LCAM";"CM";"RM";"ST"|];
                        Position = CAM
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"CM"|];
                        Position = CB
            };
                    {
                        Name = "RM";
                        Index = 9
                        Links = [|"RB";"RCAM"|];
                        Position = RM
            };
                    {
                        Name = "ST";
                        Index = 10
                        Links = [|"LCAM";"RCAM"|];
                        Position = ST
            }
        ];
    };
    let formation4512 = {
        Name = "4512";
        Positions = [
                    {
                        Name = "CM";
                        Index = 7
                        Links = [|"LCB";"RCB";"LCM";"RCM";"ST"|];
                        Position = CM
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LB";
                        Index = 1
                        Links = [|"LCB";"LM";"LCM"|];
                        Position = LB
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LB";"RCB";"LCM";"CM"|];
                        Position = CB
            };
                    {
                        Name = "LCM";
                        Index = 6
                        Links = [|"LB";"LCB";"LM";"CM"|];
                        Position = CM
            };
                    {
                        Name = "LM";
                        Index = 5
                        Links = [|"LB";"LCM";"ST"|];
                        Position = LM
            };
                    {
                        Name = "RB";
                        Index = 4
                        Links = [|"RCB";"RCM";"RM"|];
                        Position = RB
            };
                    {
                        Name = "RCB";
                        Index = 3
                        Links = [|"GK";"LCB";"RB";"CM";"RCM"|];
                        Position = CB
            };
                    {
                        Name = "RCM";
                        Index = 8
                        Links = [|"RCB";"RB";"CM";"RM"|];
                        Position = CM
            };
                    {
                        Name = "RM";
                        Index = 9
                        Links = [|"RB";"RCM";"ST"|];
                        Position = RM
            };
                    {
                        Name = "ST";
                        Index = 10
                        Links = [|"LM";"CM";"RM"|];
                        Position = ST
            }
        ];
    };
    let formation5212 = {
        Name = "5212";
        Positions = [
                    {
                        Name = "CAM";
                        Index = 7
                        Links = [|"LCM";"RCM";"LST";"RST"|];
                        Position = CAM
            };
                    {
                        Name = "CB";
                        Index = 3
                        Links = [|"GK";"LCB";"RCB";"LCM";"RCM"|];
                        Position = CB
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"CB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LWB";"CB"|];
                        Position = CB
            };
                    {
                        Name = "LCM";
                        Index = 6
                        Links = [|"LWB";"CB";"CAM";"RCM";"LST"|];
                        Position = CM
            };
                    {
                        Name = "LST";
                        Index = 9
                        Links = [|"LCM";"CAM";"RST"|];
                        Position = ST
            };
                    {
                        Name = "LWB";
                        Index = 1
                        Links = [|"LCB";"LCM"|];
                        Position = LWB
            };
                    {
                        Name = "RCB";
                        Index = 4
                        Links = [|"GK";"CB";"RWB"|];
                        Position = CB
            };
                    {
                        Name = "RCM";
                        Index = 8
                        Links = [|"CB";"RWB";"LCM";"CAM";"RST"|];
                        Position = CM
            };
                    {
                        Name = "RST";
                        Index = 10
                        Links = [|"CAM";"RCM";"LST"|];
                        Position = ST
            };
                    {
                        Name = "RWB";
                        Index = 5
                        Links = [|"RCB";"RCM"|];
                        Position = RWB
            }
        ];
    };
    let formation5221 = {
        Name = "5221";
        Positions = [
                    {
                        Name = "CB";
                        Index = 3
                        Links = [|"GK";"LCB";"RCB";"LCM";"RCM"|];
                        Position = CB
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"CB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LWB";"CB"|];
                        Position = CB
            };
                    {
                        Name = "LCM";
                        Index = 6
                        Links = [|"LWB";"CB";"RCM";"LW";"ST"|];
                        Position = CM
            };
                    {
                        Name = "LW";
                        Index = 8
                        Links = [|"LWB";"LCM";"ST"|];
                        Position = LW
            };
                    {
                        Name = "LWB";
                        Index = 1
                        Links = [|"LCB";"LCM";"LW"|];
                        Position = LWB
            };
                    {
                        Name = "RCB";
                        Index = 4
                        Links = [|"GK";"CB";"RWB"|];
                        Position = CB
            };
                    {
                        Name = "RCM";
                        Index = 7
                        Links = [|"CB";"RWB";"LCM";"ST";"RW"|];
                        Position = CM
            };
                    {
                        Name = "RW";
                        Index = 10
                        Links = [|"RWB";"RCM";"ST"|];
                        Position = RW
            };
                    {
                        Name = "RWB";
                        Index = 5
                        Links = [|"RCB";"RCM";"RW"|];
                        Position = RWB
            };
                    {
                        Name = "ST";
                        Index = 9
                        Links = [|"LCM";"RCM";"LW";"RW"|];
                        Position = ST
            }
        ];
    };
    let formation532 = {
        Name = "532";
        Positions = [
                    {
                        Name = "CB";
                        Index = 3
                        Links = [|"GK";"LCB";"RCB";"CM"|];
                        Position = CB
            };
                    {
                        Name = "CM";
                        Index = 7
                        Links = [|"CB";"LCM";"RCM";"LST";"RST"|];
                        Position = CM
            };
                    {
                        Name = "GK";
                        Index = 0
                        Links = [|"LCB";"CB";"RCB"|];
                        Position = GK
            };
                    {
                        Name = "LCB";
                        Index = 2
                        Links = [|"GK";"LWB";"CB";"LCM"|];
                        Position = CB
            };
                    {
                        Name = "LCM";
                        Index = 6
                        Links = [|"LWB";"LCB";"CM";"LST"|];
                        Position = CM
            };
                    {
                        Name = "LST";
                        Index = 9
                        Links = [|"LCM";"CM";"RST"|];
                        Position = ST
            };
                    {
                        Name = "LWB";
                        Index = 1
                        Links = [|"LCB";"LCM"|];
                        Position = LWB
            };
                    {
                        Name = "RCB";
                        Index = 4
                        Links = [|"GK";"CB";"RWB";"RCM"|];
                        Position = CB
            };
                    {
                        Name = "RCM";
                        Index = 8
                        Links = [|"RCB";"RWB";"CM";"RST"|];
                        Position = CM
            };
                    {
                        Name = "RST";
                        Index = 10
                        Links = [|"CM";"RCM";"LST"|];
                        Position = ST
            };
                    {
                        Name = "RWB";
                        Index = 5
                        Links = [|"RCB";"RCM"|];
                        Position = RWB
            }
        ];
    }
