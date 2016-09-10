namespace FSharpFUT
open FSharpFUT
module Formations =

    let formation3142 = {
        Name= "3-4-1-2";
        Positions= [
                    {
                    Index = 0;
                    Name= "GK";
                    Links = [|1;2;3;|];
                    Position= GK
                    };
                    {
                    Index = 1;
                    Name= "LCB";
                    Links = [|0;2;4;|];
                    Position= CB
                    };
                    {
                    Index = 2;
                    Name= "CB";
                    Links = [|1;0;3;5;7|];
                    Position= CB
                    };
                    {
                    Index = 3;
                    Name= "RCB";
                    Links = [|0;2;8;|];
                    Position= CB
                    };
                    {
                    Index = 4;
                    Name= "LM";
                    Links = [|1;5;9;|];
                    Position= LM
                    };
                    {
                    Index = 5;
                    Name= "LCM";
                    Links = [|2;4;7;6|];
                    Position= CM
                    };
                    {
                    Index = 6;
                    Name= "CAM";
                    Links = [|5;7;9;10|];
                    Position= CAM
                    };
                    {
                    Index = 7;
                    Name= "RCM";
                    Links = [|2;8;5;6|];
                    Position= CM
                    };
                    {
                    Index = 8;
                    Name= "RM";
                    Links = [|3;7;10|];
                    Position= RM
                    };
                    {
                    Index = 9;
                    Name= "LST";
                    Links = [|4;6;10;|];
                    Position= ST
                    };
                    {
                    Index = 10;
                    Name= "RST";
                    Links = [|8;6;9;|];
                    Position= ST
                    }
        ]
    }
