// Составить программу, которая читает натуральное число N в десятичном представлении 
// (N < 1000), а на выходе выдает это же число в десятичном представлении 
// и на естественном языке. Например, 7 -> семь; 204 -> двести четыре; 52 -> пятьдесят два.

Console.WriteLine("Введите число N < 1000");
int x = Convert.ToInt32(Console.ReadLine());

if(x<10&&x>0)
{
    if(x ==1) Console.WriteLine("1 -> Один");
    if(x ==2) Console.WriteLine("2 -> Два");
    if(x ==3) Console.WriteLine("3 -> Три");
    if(x ==4) Console.WriteLine("4 -> Четыре");
    if(x ==5) Console.WriteLine("5 -> Пять");
    if(x ==6) Console.WriteLine("6 -> Шесть");
    if(x ==7) Console.WriteLine("7 => Семь");
    if(x ==8) Console.WriteLine("8 -> Восемь");
    if(x ==9) Console.WriteLine("9 -> Девять");
}

if(x<20&&x>9)
{
    if(x ==10) Console.WriteLine("10 -> Десять");
    if(x ==11) Console.WriteLine("11 -> Одинадцать");
    if(x ==12) Console.WriteLine("12 -> Двенадцать");
    if(x ==13) Console.WriteLine("13 -> Тринадцать");
    if(x ==14) Console.WriteLine("14 -> Четырнадцать");
    if(x ==15) Console.WriteLine("15 -> Пятнадцать");
    if(x ==16) Console.WriteLine("16 -> Шестнадцать");
    if(x ==17) Console.WriteLine("17 -> Семнадцать");
    if(x ==18) Console.WriteLine("18 -> Восемнадцать");
    if(x ==19) Console.WriteLine("19 -> Девятнадцать");

}

if(x<100&&x>19)
{
    if(x ==20) Console.WriteLine("20 -> Двадцать");
    if(x ==21) Console.WriteLine("21 -> Двадцать один");
    if(x ==22) Console.WriteLine("22 -> Двадцать два");
    if(x ==23) Console.WriteLine("23 -> Двадцать три");
    if(x ==24) Console.WriteLine("24 -> Двадцать четыре");
    if(x ==25) Console.WriteLine("24 -> Двадцать пять");
    if(x ==26) Console.WriteLine("26 -> Двадцать шесть");
    if(x ==27) Console.WriteLine("27 -> Двадцать семь");
    if(x ==28) Console.WriteLine("28 -> Двадцать восемь");
    if(x ==29) Console.WriteLine("29 -> Двадцать девять");

    if(x ==30) Console.WriteLine("30 -> Тридцать");
    if(x ==31) Console.WriteLine("31 -> Тридцать  один");
    if(x ==32) Console.WriteLine("32 -> Тридцать два");
    if(x ==33) Console.WriteLine("33 -> Тридцать три");
    if(x ==34) Console.WriteLine("34 -> Тридцать четыре");
    if(x ==35) Console.WriteLine("35 -> Тридцать пять");
    if(x ==36) Console.WriteLine("36 -> Тридцать шесть");
    if(x ==37) Console.WriteLine("37 -> Тридцать семь");
    if(x ==38) Console.WriteLine("38 ->  Тридцать восемь");
    if(x ==39) Console.WriteLine("39 -> Тридцать девять");

    if(x ==40) Console.WriteLine("40 -> Сорок");
    if(x ==41) Console.WriteLine("41 -> Сорок  один");
    if(x ==42) Console.WriteLine("42 -> Сорок два");
    if(x ==43) Console.WriteLine("43 -> Сорок три");
    if(x ==44) Console.WriteLine("44 -> Сорок четыре");
    if(x ==45) Console.WriteLine("45 -> Сорок пять");
    if(x ==46) Console.WriteLine("46 -> Сорок шесть");
    if(x ==47) Console.WriteLine("47 -> Сорок семь");
    if(x ==48) Console.WriteLine("48 ->  Сорок восемь");
    if(x ==49) Console.WriteLine("49 -> Сорок девять");

    if(x ==50) Console.WriteLine("50 -> Пятьдесят");
    if(x ==51) Console.WriteLine("51 -> Пятьдесят  один");
    if(x ==52) Console.WriteLine("52 => Пятьдесят два");
    if(x ==53) Console.WriteLine("53 -> Пятьдесят три");
    if(x ==54) Console.WriteLine("54 -> Пятьдесят четыре");
    if(x ==55) Console.WriteLine("55 -> Пятьдесят пять");
    if(x ==56) Console.WriteLine("56 -> Пятьдесят шесть");
    if(x ==57) Console.WriteLine("57 -> Пятьдесят семь");
    if(x ==58) Console.WriteLine("58 -> Пятьдесят восемь");
    if(x ==59) Console.WriteLine("59 -> Пятьдесят девять");

    if(x ==60) Console.WriteLine("60 -> Шестьдесят");
    if(x ==61) Console.WriteLine("61 -> Шестьдесят  один");
    if(x ==62) Console.WriteLine("62 -> Шестьдесят два");
    if(x ==63) Console.WriteLine("63 -> Шестьдесят три");
    if(x ==64) Console.WriteLine("64 -> Шестьдесят четыре");
    if(x ==65) Console.WriteLine("65 -> Шестьдесят пять");
    if(x ==66) Console.WriteLine("66 -> Шестьдесят шесть");
    if(x ==67) Console.WriteLine("67 -> Шестьдесят семь");
    if(x ==68) Console.WriteLine("68 -> Шестьдесят восемь");
    if(x ==69) Console.WriteLine("69 -> Шестьдесят девять");

    if(x ==70) Console.WriteLine("70 -> Семьдесят");
    if(x ==71) Console.WriteLine("71 -> Семьдесят  один");
    if(x ==72) Console.WriteLine("72 -> Семьдесят два");
    if(x ==73) Console.WriteLine("73 -> Семьдесят три");
    if(x ==74) Console.WriteLine("74 -> Семьдесят четыре");
    if(x ==75) Console.WriteLine("75 -> Семьдесят пять");
    if(x ==76) Console.WriteLine("76 -> Семьдесят шесть");
    if(x ==77) Console.WriteLine("77 -> Семьдесят семь");
    if(x ==78) Console.WriteLine("78 -> Семьдесят восемь");
    if(x ==79) Console.WriteLine("79 -> Семьдесят девять");

    if(x ==80) Console.WriteLine("80 -> Восемьдесят");
    if(x ==81) Console.WriteLine("81 -> Восемьдесят  один");
    if(x ==82) Console.WriteLine("82 -> Восемьдесят два");
    if(x ==83) Console.WriteLine("83 -> Восемьдесят три");
    if(x ==84) Console.WriteLine("84 -> Восемьдесят четыре");
    if(x ==85) Console.WriteLine("85 -> Восемьдесят пять");
    if(x ==86) Console.WriteLine("86 -> Восемьдесят шесть");
    if(x ==87) Console.WriteLine("87 -> Восемьдесят семь");
    if(x ==88) Console.WriteLine("88 -> Восемьдесят восемь");
    if(x ==89) Console.WriteLine("89 -> Восемьдесят девять");

    if(x ==90) Console.WriteLine("90 -> Девяносто");
    if(x ==91) Console.WriteLine("91 -> Девяносто  один");
    if(x ==92) Console.WriteLine("92 -> Девяносто два");
    if(x ==93) Console.WriteLine("93 -> Девяносто три");
    if(x ==94) Console.WriteLine("94 -> Девяносто четыре");
    if(x ==95) Console.WriteLine("95 -> Девяносто пять");
    if(x ==96) Console.WriteLine("96 -> Девяносто шесть");
    if(x ==97) Console.WriteLine("97 -> Девяносто семь");
    if(x ==98) Console.WriteLine("98 -> Девяносто восемь");
    if(x ==99) Console.WriteLine("99 -> Девяносто девять");

}

if(x<1000&&x >99)
{
    if(x ==100) Console.WriteLine("100 -> Сто");
    if(x ==101) Console.WriteLine("101 -> Сто один");
    if(x ==102) Console.WriteLine("102 -> Сто два");
    if(x ==103) Console.WriteLine("103 -> Сто три");
    if(x ==104) Console.WriteLine("104 -> Сто четыре");
    if(x ==105) Console.WriteLine("105 -> Сто пять");
    if(x ==106) Console.WriteLine("106 -> Сто шесть");
    if(x ==107) Console.WriteLine("107 -> Сто семь");
    if(x ==108) Console.WriteLine("108 -> Сто восемь");
    if(x ==109) Console.WriteLine("109 -> Сто девять");

    if(x ==110) Console.WriteLine("110 -> Сто десять");
    if(x ==111) Console.WriteLine("111 -> Сто одинадцать");
    if(x ==112) Console.WriteLine("112 -> Сто двенадцать");
    if(x ==113) Console.WriteLine("113 -> Сто тринадцать");
    if(x ==114) Console.WriteLine("114 -> Сто четырнадцать");
    if(x ==115) Console.WriteLine("115 -> Сто пятнадцать");
    if(x ==116) Console.WriteLine("116 -> Сто шестнадцать");
    if(x ==117) Console.WriteLine("117 -> Сто семнадцать");
    if(x ==118) Console.WriteLine("118 -> Сто восемнадцать");
    if(x ==119) Console.WriteLine("119 -> Сто девятнадцать");

    if(x ==120) Console.WriteLine("120 -> Сто двадцать");
    if(x ==121) Console.WriteLine("121 -> Сто двадцать один");
    if(x ==122) Console.WriteLine("122 -> Сто двадцать два");
    if(x ==123) Console.WriteLine("123 -> Сто двадцатьтри");
    if(x ==124) Console.WriteLine("124 -> Сто двадцать четыре");
    if(x ==125) Console.WriteLine("125 -> Сто двадцать пять");
    if(x ==126) Console.WriteLine("126 -> Сто двадцать шесть");
    if(x ==127) Console.WriteLine("127 -> Сто двадцать семь");
    if(x ==128) Console.WriteLine("128 -> Сто двадцать восемь");
    if(x ==129) Console.WriteLine("129 -> Сто двадцать девять");

     if(x ==130) Console.WriteLine("130 -> Сто тридцать");
    if(x ==131) Console.WriteLine("131 -> Сто тридцать один");
    if(x ==132) Console.WriteLine("132 -> Сто тридцать два");
    if(x ==133) Console.WriteLine("133 -> Сто тридцатьтри");
    if(x ==134) Console.WriteLine("134 -> Сто тридцать четыре");
    if(x ==135) Console.WriteLine("135 -> Сто тридцать пять");
    if(x ==136) Console.WriteLine("136 -> Сто тридцать шесть");
    if(x ==137) Console.WriteLine("137 -> Сто тридцать семь");
    if(x ==138) Console.WriteLine("138 -> Сто тридцать восемь");
    if(x ==139) Console.WriteLine("139 -> Сто тридцать девять");

    if(x ==140) Console.WriteLine("140 -> Сто сорок");
    if(x ==141) Console.WriteLine("141 -> Сто сорок один");
    if(x ==142) Console.WriteLine("142 -> Сто тридцать два");
    if(x ==143) Console.WriteLine("143 -> Сто тридцатьтри");
    if(x ==144) Console.WriteLine("144 -> Сто тридцать четыре");
    if(x ==145) Console.WriteLine("145 -> Сто тридцать пять");
    if(x ==146) Console.WriteLine("146 -> Сто тридцать шесть");
    if(x ==147) Console.WriteLine("147 -> Сто тридцать семь");
    if(x ==148) Console.WriteLine("148 -> Сто тридцать восемь");
    if(x ==149) Console.WriteLine("149 -> Сто тридцать девять");

    if(x ==150) Console.WriteLine("150 -> Сто пятьдесят");
    if(x ==151) Console.WriteLine("151 -> Сто пятьдесят один");
    if(x ==152) Console.WriteLine("152 -> Сто пятьдесят два");
    if(x ==153) Console.WriteLine("153 -> Сто пятьдесят три");
    if(x ==154) Console.WriteLine("154 -> Сто пятьдесят четыре");
    if(x ==155) Console.WriteLine("155 -> Сто пятьдесят пять");
    if(x ==156) Console.WriteLine("156 -> Сто пятьдесят шесть");
    if(x ==157) Console.WriteLine("157 -> Сто пятьдесят семь");
    if(x ==158) Console.WriteLine("158 -> Сто пятьдесят восемь");
    if(x ==159) Console.WriteLine("159 -> Сто пятьдесят девять");

    if(x ==160) Console.WriteLine("160 -> Сто шестьдесят");
    if(x ==161) Console.WriteLine("161 -> Сто шестьдесят один");
    if(x ==162) Console.WriteLine("162 -> Сто шестьдесят два");
    if(x ==163) Console.WriteLine("163 -> Сто шестьдесят три");
    if(x ==164) Console.WriteLine("164 -> Сто шестьдесят четыре");
    if(x ==165) Console.WriteLine("165 -> Сто шестьдесят пять");
    if(x ==166) Console.WriteLine("166 -> Сто шестьдесят шесть");
    if(x ==167) Console.WriteLine("167 -> Сто шестьдесят семь");
    if(x ==168) Console.WriteLine("168 -> Сто шестьдесят восемь");
    if(x ==169) Console.WriteLine("169 -> Сто шестьдесят девять");

    if(x ==170) Console.WriteLine("170 -> Сто семьдесят");
    if(x ==171) Console.WriteLine("171 -> Сто семьдесят один");
    if(x ==172) Console.WriteLine("172 -> Сто семьдесят два");
    if(x ==173) Console.WriteLine("173 -> Сто семьдесят три");
    if(x ==174) Console.WriteLine("174 -> Сто семьдесят четыре");
    if(x ==175) Console.WriteLine("175 -> Сто семьдесят пять");
    if(x ==176) Console.WriteLine("176 -> Сто семьдесят шесть");
    if(x ==177) Console.WriteLine("177 -> Сто семьдесят семь");
    if(x ==178) Console.WriteLine("178 -> Сто семьдесят восемь");
    if(x ==179) Console.WriteLine("179 -> Сто семьдесят девять");

    if(x ==180) Console.WriteLine("180 -> Сто восемьдесят");
    if(x ==181) Console.WriteLine("181 -> Сто восемьдесят один");
    if(x ==182) Console.WriteLine("182 -> Сто восемьдесят два");
    if(x ==183) Console.WriteLine("183 -> Сто восемьдесят три");
    if(x ==184) Console.WriteLine("184 -> Сто восемьдесят четыре");
    if(x ==185) Console.WriteLine("185 -> Сто восемьдесят пять");
    if(x ==186) Console.WriteLine("186 -> Сто восемьдесят шесть");
    if(x ==187) Console.WriteLine("187 -> Сто восемьдесят семь");
    if(x ==188) Console.WriteLine("188 -> Сто восемьдесят восемь");
    if(x ==189) Console.WriteLine("189 -> Сто восемьдесят девять");

    if(x ==190) Console.WriteLine("190 -> Сто девяносто");
    if(x ==191) Console.WriteLine("191 -> Сто девяносто один");
    if(x ==192) Console.WriteLine("192 -> Сто девяносто два");
    if(x ==193) Console.WriteLine("193 -> Сто девяносто три");
    if(x ==194) Console.WriteLine("194 -> Сто девяносто четыре");
    if(x ==195) Console.WriteLine("195 -> Сто девяносто пять");
    if(x ==196) Console.WriteLine("196 -> Сто девяносто шесть");
    if(x ==197) Console.WriteLine("197 -> Сто девяносто семь");
    if(x ==198) Console.WriteLine("198 -> Сто девяносто восемь");
    if(x ==199) Console.WriteLine("199 -> Сто девяносто девять");

      if(x ==200) Console.WriteLine("200 -> Двести");
    if(x ==201) Console.WriteLine("201 -> Двести один");
    if(x ==202) Console.WriteLine("202 -> Двести два");
    if(x ==203) Console.WriteLine("203 -> Двести три");
    if(x ==204) Console.WriteLine("204 => Двести четыре");
    if(x ==205) Console.WriteLine("205 -> Двести пять");
    if(x ==206) Console.WriteLine("206 -> Двести шесть");
    if(x ==207) Console.WriteLine("207 -> Двести семь");
    if(x ==208) Console.WriteLine("208 -> Двести восемь");
    if(x ==209) Console.WriteLine("209 -> Двести девять");

      if(x ==220) Console.WriteLine("220 -> Двести  двадцать");
    if(x ==221) Console.WriteLine("221 -> Двести  двадцать один");
    if(x ==222) Console.WriteLine("222 -> Двести  двадцать два");
    if(x ==223) Console.WriteLine("223 -> Двести  двадцатьтри");
    if(x ==224) Console.WriteLine("224 -> Двести  двадцать четыре");
    if(x ==225) Console.WriteLine("225 -> Двести  двадцать пять");
    if(x ==226) Console.WriteLine("226 -> Двести  двадцать шесть");
    if(x ==227) Console.WriteLine("227 -> Двести  двадцать семь");
    if(x ==228) Console.WriteLine("228 -> Двести  двадцать восемь");
    if(x ==229) Console.WriteLine("229 -> Двести  двадцать девять");

     if(x ==230) Console.WriteLine("230 -> Двести  тридцать");
    if(x ==231) Console.WriteLine("231 -> Двести  тридцать один");
    if(x ==232) Console.WriteLine("232 -> Двести  тридцать два");
    if(x ==233) Console.WriteLine("233 -> Двести  тридцатьтри");
    if(x ==234) Console.WriteLine("234 -> Двести  тридцать четыре");
    if(x ==235) Console.WriteLine("235 -> Двести  тридцать пять");
    if(x ==236) Console.WriteLine("236 -> Двести тридцать шесть");
    if(x ==237) Console.WriteLine("237 -> Двести  тридцать семь");
    if(x ==238) Console.WriteLine("238 -> Двести  тридцать восемь");
    if(x ==239) Console.WriteLine("239 -> Двести  тридцать девять");

    if(x ==240) Console.WriteLine("240 -> Двести  сорок");
    if(x ==241) Console.WriteLine("241 -> Двести  сорок один");
    if(x ==242) Console.WriteLine("242 -> Двести  тридцать два");
    if(x ==243) Console.WriteLine("243 -> Двести  тридцать три");
    if(x ==244) Console.WriteLine("244 -> Двести тридцать четыре");
    if(x ==245) Console.WriteLine("245 -> Двести  тридцать пять");
    if(x ==246) Console.WriteLine("246 -> Двести  тридцать шесть");
    if(x ==247) Console.WriteLine("247 -> Двести  тридцать семь");
    if(x ==248) Console.WriteLine("248 -> Двести  тридцать восемь");
    if(x ==249) Console.WriteLine("249 -> Двести тридцать девять");

    if(x ==250) Console.WriteLine("250 -> Двести  пятьдесят");
    if(x ==251) Console.WriteLine("251 -> Двести  пятьдесят один");
    if(x ==252) Console.WriteLine("252 -> Двести  пятьдесят два");
    if(x ==253) Console.WriteLine("253 -> Двести  пятьдесят три");
    if(x ==254) Console.WriteLine("254 -> Двести  пятьдесят четыре");
    if(x ==255) Console.WriteLine("255 -> Двести  пятьдесят пять");
    if(x ==256) Console.WriteLine("256 -> Двести  пятьдесят шесть");
    if(x ==257) Console.WriteLine("257 -> Двести  пятьдесят семь");
    if(x ==258) Console.WriteLine("258 -> Двести  пятьдесят восемь");
    if(x ==259) Console.WriteLine("259 -> Двести  пятьдесят девять");

    if(x ==260) Console.WriteLine("260 -> Двести  шестьдесят");
    if(x ==261) Console.WriteLine("261 -> Двести  шестьдесят один");
    if(x ==262) Console.WriteLine("262 -> Двести  шестьдесят два");
    if(x ==263) Console.WriteLine("263 -> Двести  шестьдесят три");
    if(x ==264) Console.WriteLine("264 -> Двести  шестьдесят четыре");
    if(x ==265) Console.WriteLine("265 -> Двести  шестьдесят пять");
    if(x ==266) Console.WriteLine("266 -> Двести  шестьдесят шесть");
    if(x ==267) Console.WriteLine("267 -> Двести  шестьдесят семь");
    if(x ==268) Console.WriteLine("268 -> Двести  шестьдесят восемь");
    if(x ==269) Console.WriteLine("269 -> Двести  шестьдесят девять");

    if(x ==270) Console.WriteLine("270 -> Двести  семьдесят");
    if(x ==271) Console.WriteLine("271 -> Двести  семьдесят один");
    if(x ==272) Console.WriteLine("272 -> Двести  семьдесят два");
    if(x ==273) Console.WriteLine("273 -> Двести  семьдесят три");
    if(x ==274) Console.WriteLine("274 -> Двести  семьдесят четыре");
    if(x ==275) Console.WriteLine("275 -> Двести  семьдесят пять");
    if(x ==276) Console.WriteLine("276 -> Двести  семьдесят шесть");
    if(x ==277) Console.WriteLine("277 -> Двести  семьдесят семь");
    if(x ==278) Console.WriteLine("278 -> Двести  семьдесят восемь");
    if(x ==279) Console.WriteLine("279 -> Двести  семьдесят девять");

    if(x ==280) Console.WriteLine("280 -> Двести  восемьдесят");
    if(x ==281) Console.WriteLine("281 -> Двести  восемьдесят один");
    if(x ==282) Console.WriteLine("282 -> Двести  восемьдесят два");
    if(x ==283) Console.WriteLine("283 -> Двести  восемьдесят три");
    if(x ==284) Console.WriteLine("284 -> Двести  восемьдесят четыре");
    if(x ==285) Console.WriteLine("285 -> Двести  восемьдесят пять");
    if(x ==286) Console.WriteLine("286 -> Двести  восемьдесят шесть");
    if(x ==287) Console.WriteLine("287 -> Двести  восемьдесят семь");
    if(x ==288) Console.WriteLine("288 -> Двести  восемьдесят восемь");
    if(x ==289) Console.WriteLine("289 -> Двести  восемьдесят девять");

    if(x ==290) Console.WriteLine("290 -> Двести  девяносто");
    if(x ==291) Console.WriteLine("291 -> Двести  девяносто один");
    if(x ==292) Console.WriteLine("292 -> Двести  девяносто два");
    if(x ==293) Console.WriteLine("293 -> Двести  девяносто три");
    if(x ==294) Console.WriteLine("294 -> Двести  девяносто четыре");
    if(x ==295) Console.WriteLine("295 -> Двести  девяносто пять");
    if(x ==296) Console.WriteLine("296 -> Двести  девяносто шесть");
    if(x ==297) Console.WriteLine("297 -> Двести  девяносто семь");
    if(x ==298) Console.WriteLine("298 -> Двести  девяносто восемь");
    if(x ==299) Console.WriteLine("299 -> Двести  девяносто девять");


    if(x ==300) Console.WriteLine("300 -> Триста");
    if(x ==301) Console.WriteLine("301 -> Триста один"); 
    if(x ==302) Console.WriteLine("302 -> Триста два");
    if(x ==303) Console.WriteLine("303 -> Триста три");
    if(x ==304) Console.WriteLine("304 -> Триста четыре");
    if(x ==305) Console.WriteLine("305 -> Триста пять");
    if(x ==306) Console.WriteLine("306 -> Триста шесть");
    if(x ==307) Console.WriteLine("307 -> Триста семь");
    if(x ==308) Console.WriteLine("308 -> Триста восемь");
    if(x ==309) Console.WriteLine("309 -> Триста девять");

    if(x ==310) Console.WriteLine("110 -> Триста десять");
    if(x ==311) Console.WriteLine("311 -> Триста одинадцать");
    if(x ==312) Console.WriteLine("312 -> Триста двенадцать");
    if(x ==313) Console.WriteLine("313 -> Триста тринадцать");
    if(x ==314) Console.WriteLine("314 -> Триста четырнадцать");
    if(x ==315) Console.WriteLine("315 -> Триста пятнадцать");
    if(x ==316) Console.WriteLine("316 -> Триста шестнадцать");
    if(x ==317) Console.WriteLine("317 -> Триста семнадцать");
    if(x ==318) Console.WriteLine("318 -> Триста восемнадцать");
    if(x ==319) Console.WriteLine("319 -> Триста девятнадцать");

    if(x ==320) Console.WriteLine("320 -> Триста двадцать");
    if(x ==321) Console.WriteLine("321 -> Триста двадцать один");
    if(x ==322) Console.WriteLine("322 -> Триста двадцать два");
    if(x ==323) Console.WriteLine("323 -> Триста двадцатьтри");
    if(x ==324) Console.WriteLine("324 -> Триста двадцать четыре");
    if(x ==325) Console.WriteLine("325 -> Триста двадцать пять");
    if(x ==326) Console.WriteLine("326 -> Триста двадцать шесть");
    if(x ==327) Console.WriteLine("327 -> Триста двадцать семь");
    if(x ==328) Console.WriteLine("328 -> Триста двадцать восемь");
    if(x ==329) Console.WriteLine("329 -> Триста двадцать девять");

    if(x ==330) Console.WriteLine("330 -> Триста тридцать");
    if(x ==331) Console.WriteLine("331 -> Триста тридцать один");
    if(x ==332) Console.WriteLine("332 -> Тристатридцать два");
    if(x ==333) Console.WriteLine("333 -> Триста тридцать три");
    if(x ==334) Console.WriteLine("334 -> Триста тридцать четыре");
    if(x ==335) Console.WriteLine("335 -> Триста тридцать пять");
    if(x ==336) Console.WriteLine("336 -> Триста тридцать шесть");
    if(x ==337) Console.WriteLine("337 -> Триста тридцать семь");
    if(x ==338) Console.WriteLine("338 -> Триста тридцать восемь");
    if(x ==339) Console.WriteLine("339 -> Триста тридцать девять");

    if(x ==340) Console.WriteLine("340 -> Триста сорок");
    if(x ==341) Console.WriteLine("341 -> Триста сорок один");
    if(x ==342) Console.WriteLine("342 -> Триста сорок два");
    if(x ==343) Console.WriteLine("343 -> Триста сорок три");
    if(x ==344) Console.WriteLine("344 -> Триста сорок четыре");
    if(x ==345) Console.WriteLine("345 -> Триста сорок пять");
    if(x ==346) Console.WriteLine("346 -> Триста сорок шесть");
    if(x ==347) Console.WriteLine("347 -> Триста сорок семь");
    if(x ==348) Console.WriteLine("348 -> Триста сорок восемь");
    if(x ==349) Console.WriteLine("349 -> Триста сорок девять");

    if(x ==350) Console.WriteLine("350 -> Триста пятьдесят");
    if(x ==351) Console.WriteLine("351 -> Триста пятьдесят один");
    if(x ==352) Console.WriteLine("352 -> Триста пятьдесят два");
    if(x ==353) Console.WriteLine("353 -> Триста пятьдесят три");
    if(x ==354) Console.WriteLine("354 -> Триста пятьдесят четыре");
    if(x ==355) Console.WriteLine("355 -> Триста пятьдесят пять");
    if(x ==356) Console.WriteLine("356 -> Триста пятьдесят шесть");
    if(x ==357) Console.WriteLine("357 -> Триста пятьдесят семь");
    if(x ==358) Console.WriteLine("358 -> Триста пятьдесят восемь");
    if(x ==359) Console.WriteLine("359 -> Триста пятьдесят девять");

    if(x ==360) Console.WriteLine("360 -> Триста шестьдесят");
    if(x ==361) Console.WriteLine("361 -> Триста шестьдесят один");
    if(x ==362) Console.WriteLine("362 -> Триста шестьдесят два");
    if(x ==363) Console.WriteLine("363 -> Триста шестьдесят три");
    if(x ==364) Console.WriteLine("364 -> Триста шестьдесят четыре");
    if(x ==365) Console.WriteLine("365 -> Триста шестьдесят пять");
    if(x ==366) Console.WriteLine("366 -> Триста шестьдесят шесть");
    if(x ==367) Console.WriteLine("367 -> Триста шестьдесят семь");
    if(x ==368) Console.WriteLine("368 -> Триста шестьдесят восемь");
    if(x ==369) Console.WriteLine("369 -> Триста шестьдесят девять");

    if(x ==370) Console.WriteLine("370 -> Триста семьдесят");
    if(x ==371) Console.WriteLine("371 -> Триста семьдесят один");
    if(x ==372) Console.WriteLine("372 -> Триста семьдесят два");
    if(x ==373) Console.WriteLine("373 -> Триста семьдесят три");
    if(x ==374) Console.WriteLine("374 -> Триста семьдесят четыре");
    if(x ==375) Console.WriteLine("375 -> Триста семьдесят пять");
    if(x ==376) Console.WriteLine("376 -> Триста семьдесят шесть");
    if(x ==377) Console.WriteLine("377 -> Триста семьдесят семь");
    if(x ==378) Console.WriteLine("378 -> Триста семьдесят восемь");
    if(x ==379) Console.WriteLine("379 -> Триста семьдесят девять");

    if(x ==380) Console.WriteLine("380 -> Триста восемьдесят");
    if(x ==381) Console.WriteLine("381 -> Триста восемьдесят один");
    if(x ==382) Console.WriteLine("382 -> Триста восемьдесят два");
    if(x ==383) Console.WriteLine("383 -> Триста восемьдесят три");
    if(x ==384) Console.WriteLine("384 -> Триста восемьдесят четыре");
    if(x ==385) Console.WriteLine("385 -> Триста восемьдесят пять");
    if(x ==386) Console.WriteLine("386 -> Триста восемьдесят шесть");
    if(x ==387) Console.WriteLine("387 -> Триста восемьдесят семь");
    if(x ==388) Console.WriteLine("388 -> Триста восемьдесят восемь");
    if(x ==389) Console.WriteLine("389 -> Триста восемьдесят девять");

    if(x ==390) Console.WriteLine("390 -> Триста девяносто");
    if(x ==391) Console.WriteLine("391 -> Триста девяносто один");
    if(x ==392) Console.WriteLine("392 -> Триста девяносто два");
    if(x ==393) Console.WriteLine("393 -> Триста девяносто три");
    if(x ==394) Console.WriteLine("394 -> Триста девяносто четыре");
    if(x ==395) Console.WriteLine("395 -> Триста девяносто пять");
    if(x ==396) Console.WriteLine("396 -> Триста девяносто шесть");
    if(x ==397) Console.WriteLine("397 -> Триста девяносто семь");
    if(x ==398) Console.WriteLine("398 -> Триста девяносто восемь");
    if(x ==399) Console.WriteLine("399 -> Триста девяносто девять");



    if(x ==401) Console.WriteLine("401 -> Четыреста");
    if(x ==401) Console.WriteLine("401 -> Четыреста один"); 
    if(x ==402) Console.WriteLine("402 -> Четыреста два");
    if(x ==403) Console.WriteLine("403 -> Четыреста три");
    if(x ==404) Console.WriteLine("404 -> Четыреста четыре");
    if(x ==405) Console.WriteLine("405 -> Четыреста пять");
    if(x ==406) Console.WriteLine("406 -> Четыреста шесть");
    if(x ==407) Console.WriteLine("407 -> Четыреста семь");
    if(x ==408) Console.WriteLine("408 -> Четыреста восемь");
    if(x ==409) Console.WriteLine("409 -> Четыреста девять");

    if(x ==410) Console.WriteLine("410 -> Четыреста десять");
    if(x ==411) Console.WriteLine("411 -> Четыреста одинадцать");
    if(x ==412) Console.WriteLine("412 -> Четыреста двенадцать");
    if(x ==413) Console.WriteLine("413 -> Четыреста тринадцать");
    if(x ==414) Console.WriteLine("414 -> Четыреста четырнадцать");
    if(x ==415) Console.WriteLine("415 -> Четыреста пятнадцать");
    if(x ==416) Console.WriteLine("416 -> Четыреста шестнадцать");
    if(x ==417) Console.WriteLine("417 -> Четыреста семнадцать");
    if(x ==418) Console.WriteLine("418 -> Четыреста восемнадцать");
    if(x ==419) Console.WriteLine("419 -> Четыреста девятнадцать");

    if(x ==420) Console.WriteLine("420 -> Четыреста двадцать");
    if(x ==421) Console.WriteLine("421 -> Четыреста двадцать один");
    if(x ==422) Console.WriteLine("422 -> Четыреста двадцать два");
    if(x ==423) Console.WriteLine("423 -> Четыреста двадцать три");
    if(x ==424) Console.WriteLine("424 -> Четыреста двадцать четыре");
    if(x ==425) Console.WriteLine("425 -> Четыреста двадцать пять");
    if(x ==426) Console.WriteLine("426 -> Четыреста двадцать шесть");
    if(x ==427) Console.WriteLine("427 -> Четыреста двадцать семь");
    if(x ==428) Console.WriteLine("428 -> Четыреста двадцать восемь");
    if(x ==429) Console.WriteLine("429 -> Четыреста двадцать девять");

     if(x ==430) Console.WriteLine("430 -> Четыреста тридцать");
    if(x ==431) Console.WriteLine("431 -> Четыреста тридцать один");
    if(x ==432) Console.WriteLine("432 -> Четыреста тридцать два");
    if(x ==433) Console.WriteLine("433 -> Четыреста тридцать три");
    if(x ==434) Console.WriteLine("434 -> Четыреста тридцать четыре");
    if(x ==435) Console.WriteLine("435 -> Четыреста тридцать пять");
    if(x ==436) Console.WriteLine("436 -> Четыреста тридцать шесть");
    if(x ==437) Console.WriteLine("437 -> Четыреста тридцать семь");
    if(x ==438) Console.WriteLine("438 -> Четыреста тридцать восемь");
    if(x ==439) Console.WriteLine("439 -> Четыреста тридцать девять");

    if(x ==440) Console.WriteLine("440 -> Четыреста сорок");
    if(x ==441) Console.WriteLine("441 -> Четыреста сорок один");
    if(x ==442) Console.WriteLine("442 -> Четыреста тридцать два");
    if(x ==443) Console.WriteLine("443 -> Четыреста тридцать три");
    if(x ==444) Console.WriteLine("444 -> Четыреста тридцать четыре");
    if(x ==445) Console.WriteLine("445 -> Четыреста тридцать пять");
    if(x ==446) Console.WriteLine("446 -> Четыреста тридцать шесть");
    if(x ==447) Console.WriteLine("447 -> Четыреста тридцать семь");
    if(x ==448) Console.WriteLine("448 -> Четыреста тридцать восемь");
    if(x ==449) Console.WriteLine("449 -> Четыреста тридцать девять");

    if(x ==450) Console.WriteLine("450 -> Четыреста пятьдесят");
    if(x ==451) Console.WriteLine("451 -> Четыреста пятьдесят один");
    if(x ==452) Console.WriteLine("452 -> Четыреста пятьдесят два");
    if(x ==453) Console.WriteLine("453 -> Четыреста пятьдесят три");
    if(x ==454) Console.WriteLine("454 -> Четыреста пятьдесят четыре");
    if(x ==455) Console.WriteLine("455 -> Четыреста пятьдесят пять");
    if(x ==456) Console.WriteLine("456 -> Четыреста пятьдесят шесть");
    if(x ==457) Console.WriteLine("457 -> Четыреста пятьдесят семь");
    if(x ==458) Console.WriteLine("458 -> Четыреста пятьдесят восемь");
    if(x ==459) Console.WriteLine("459 -> Четыреста пятьдесят девять");

    if(x ==460) Console.WriteLine("460 -> Четыреста шестьдесят");
    if(x ==461) Console.WriteLine("461 -> Четыреста шестьдесят один");
    if(x ==462) Console.WriteLine("462 -> Четыреста шестьдесят два");
    if(x ==463) Console.WriteLine("463 -> Четыреста шестьдесят три");
    if(x ==464) Console.WriteLine("464 -> Четыреста шестьдесят четыре");
    if(x ==465) Console.WriteLine("465 -> Четыреста шестьдесят пять");
    if(x ==466) Console.WriteLine("466 -> Четыреста шестьдесят шесть");
    if(x ==467) Console.WriteLine("467 -> Четыреста шестьдесят семь");
    if(x ==468) Console.WriteLine("468 -> Четыреста шестьдесят восемь");
    if(x ==469) Console.WriteLine("469 -> Четыреста шестьдесят девять");

    if(x ==470) Console.WriteLine("470 -> Четыреста семьдесят");
    if(x ==471) Console.WriteLine("471 -> Четыреста семьдесят один");
    if(x ==472) Console.WriteLine("472 -> Четыреста семьдесят два");
    if(x ==473) Console.WriteLine("473 -> Четыреста семьдесят три");
    if(x ==474) Console.WriteLine("474 -> Четыреста семьдесят четыре");
    if(x ==475) Console.WriteLine("475 -> Четыреста семьдесят пять");
    if(x ==476) Console.WriteLine("476 -> Четыреста семьдесят шесть");
    if(x ==477) Console.WriteLine("477 -> Четыреста семьдесят семь");
    if(x ==478) Console.WriteLine("478 -> Четыреста семьдесят восемь");
    if(x ==479) Console.WriteLine("479 -> Четыреста семьдесят девять");

    if(x ==480) Console.WriteLine("480 -> Четыреста восемьдесят");
    if(x ==481) Console.WriteLine("481 -> Четыреста восемьдесят один");
    if(x ==482) Console.WriteLine("482 -> Четыреста восемьдесят два");
    if(x ==483) Console.WriteLine("483 -> Четыреста восемьдесят три");
    if(x ==484) Console.WriteLine("484 -> Четыреста восемьдесят четыре");
    if(x ==485) Console.WriteLine("485 -> Четыреста восемьдесят пять");
    if(x ==486) Console.WriteLine("486 -> Четыреста восемьдесят шесть");
    if(x ==487) Console.WriteLine("487 -> Четыреста восемьдесят семь");
    if(x ==488) Console.WriteLine("488 -> Четыреста восемьдесят восемь");
    if(x ==489) Console.WriteLine("489 -> Четыреста восемьдесят девять");

    if(x ==490) Console.WriteLine("490 -> Четыреста девяносто");
    if(x ==491) Console.WriteLine("491 -> Четыреста девяносто один");
    if(x ==492) Console.WriteLine("492 -> Четыреста девяносто два");
    if(x ==493) Console.WriteLine("493 -> Четыреста девяносто три");
    if(x ==494) Console.WriteLine("494 -> Четыреста девяносто четыре");
    if(x ==495) Console.WriteLine("495 -> Четыреста девяносто пять");
    if(x ==496) Console.WriteLine("496 -> Четыреста девяносто шесть");
    if(x ==497) Console.WriteLine("497 -> Четыреста девяносто семь");
    if(x ==498) Console.WriteLine("498 -> Четыреста девяносто восемь");
    if(x ==499) Console.WriteLine("499 -> Четыреста девяносто девять");



    if(x ==500) Console.WriteLine("500 -> Пятьсот");
     if(x ==501) Console.WriteLine("501 -> Пятьсот один"); 
    if(x ==502) Console.WriteLine("502 -> Пятьсот два");
    if(x ==503) Console.WriteLine("503 -> Пятьсот три");
    if(x ==504) Console.WriteLine("504 -> Пятьсот четыре");
    if(x ==505) Console.WriteLine("505 -> Пятьсот пять");
    if(x ==506) Console.WriteLine("506 -> Пятьсот шесть");
    if(x ==507) Console.WriteLine("507 -> Пятьсот семь");
    if(x ==508) Console.WriteLine("508 -> Пятьсот восемь");
    if(x ==509) Console.WriteLine("509 -> Пятьсот девять");

    if(x ==510) Console.WriteLine("510 -> Пятьсот десять");
    if(x ==511) Console.WriteLine("511 -> Пятьсот одинадцать");
    if(x ==512) Console.WriteLine("512 -> Пятьсот двенадцать");
    if(x ==513) Console.WriteLine("513 -> Пятьсот тринадцать");
    if(x ==514) Console.WriteLine("514 -> Пятьсот четырнадцать");
    if(x ==515) Console.WriteLine("515 -> Пятьсот пятнадцать");
    if(x ==516) Console.WriteLine("516 -> Пятьсот шестнадцать");
    if(x ==517) Console.WriteLine("517 -> Пятьсот семнадцать");
    if(x ==518) Console.WriteLine("518 -> Пятьсот восемнадцать");
    if(x ==519) Console.WriteLine("519 -> Пятьсот девятнадцать");

    if(x ==520) Console.WriteLine("520 -> Пятьсот двадцать");
    if(x ==521) Console.WriteLine("521 -> Пятьсот двадцать один");
    if(x ==522) Console.WriteLine("522 -> Пятьсот двадцать два");
    if(x ==523) Console.WriteLine("523 -> Пятьсот двадцать три");
    if(x ==524) Console.WriteLine("524 -> Пятьсот двадцать четыре");
    if(x ==525) Console.WriteLine("525 -> Пятьсот двадцать пять");
    if(x ==526) Console.WriteLine("526 -> Пятьсот двадцать шесть");
    if(x ==527) Console.WriteLine("527 -> Пятьсот двадцать семь");
    if(x ==528) Console.WriteLine("528 -> Пятьсот двадцать восемь");
    if(x ==529) Console.WriteLine("529 -> Пятьсот двадцать девять");

     if(x ==530) Console.WriteLine("530 -> Пятьсот тридцать");
    if(x ==531) Console.WriteLine("531 -> Пятьсот тридцать один");
    if(x ==532) Console.WriteLine("532 -> Пятьсот тридцать два");
    if(x ==533) Console.WriteLine("533 -> Пятьсот тридцать три");
    if(x ==534) Console.WriteLine("534 -> Пятьсот тридцать четыре");
    if(x ==535) Console.WriteLine("535 -> Пятьсот тридцать пять");
    if(x ==536) Console.WriteLine("536 -> Пятьсот тридцать шесть");
    if(x ==537) Console.WriteLine("537 -> Пятьсот тридцать семь");
    if(x ==538) Console.WriteLine("538 -> Пятьсот тридцать восемь");
    if(x ==539) Console.WriteLine("539 -> Пятьсот тридцать девять");

    if(x ==540) Console.WriteLine("540 -> Пятьсот сорок");
    if(x ==541) Console.WriteLine("541 -> Пятьсот сорок один");
    if(x ==542) Console.WriteLine("542 -> Пятьсот тридцать два");
    if(x ==543) Console.WriteLine("543 -> Пятьсот тридцать три");
    if(x ==544) Console.WriteLine("544 -> Пятьсот тридцать четыре");
    if(x ==545) Console.WriteLine("545 -> Пятьсот тридцать пять");
    if(x ==546) Console.WriteLine("546 -> Пятьсот тридцать шесть");
    if(x ==547) Console.WriteLine("547 -> Пятьсот тридцать семь");
    if(x ==548) Console.WriteLine("548 -> Пятьсот тридцать восемь");
    if(x ==549) Console.WriteLine("549 -> Пятьсот тридцать девять");

    if(x ==550) Console.WriteLine("550 -> Пятьсот пятьдесят");
    if(x ==551) Console.WriteLine("551 -> Пятьсот  пятьдесят один");
    if(x ==552) Console.WriteLine("552 -> Пятьсот пятьдесят два");
    if(x ==553) Console.WriteLine("553 -> Пятьсот пятьдесят три");
    if(x ==554) Console.WriteLine("554 -> Пятьсот пятьдесят четыре");
    if(x ==555) Console.WriteLine("555 -> Пятьсот пятьдесят пять");
    if(x ==556) Console.WriteLine("556 -> Пятьсот пятьдесят шесть");
    if(x ==557) Console.WriteLine("557 -> Пятьсот пятьдесят семь");
    if(x ==558) Console.WriteLine("558 -> Пятьсот пятьдесят восемь");
    if(x ==559) Console.WriteLine("559 -> Пятьсот пятьдесят девять");

    if(x ==560) Console.WriteLine("560 -> Пятьсот шестьдесят");
    if(x ==561) Console.WriteLine("561 -> Пятьсот шестьдесят один");
    if(x ==562) Console.WriteLine("562 -> Пятьсот шестьдесят два");
    if(x ==353) Console.WriteLine("563 -> Пятьсот шестьдесят три");
    if(x ==564) Console.WriteLine("564 -> Пятьсот шестьдесят четыре");
    if(x ==565) Console.WriteLine("565 -> Пятьсот шестьдесят пять");
    if(x ==566) Console.WriteLine("566 -> Пятьсот шестьдесят шесть");
    if(x ==567) Console.WriteLine("567 -> Пятьсот шестьдесят семь");
    if(x ==568) Console.WriteLine("568 -> Пятьсот шестьдесят восемь");
    if(x ==569) Console.WriteLine("569 -> Пятьсот шестьдесят девять");

    if(x ==570) Console.WriteLine("570 -> Пятьсот семьдесят");
    if(x ==571) Console.WriteLine("571 -> Пятьсот семьдесят один");
    if(x ==572) Console.WriteLine("572 -> Пятьсот семьдесят два");
    if(x ==573) Console.WriteLine("573 -> Пятьсот семьдесят три");
    if(x ==574) Console.WriteLine("574 -> Пятьсот семьдесят четыре");
    if(x ==575) Console.WriteLine("575 -> Пятьсот семьдесят пять");
    if(x ==576) Console.WriteLine("576 -> Пятьсот семьдесят шесть");
    if(x ==577) Console.WriteLine("577 -> Пятьсот семьдесят семь");
    if(x ==578) Console.WriteLine("578 -> Пятьсот семьдесят восемь");
    if(x ==579) Console.WriteLine("579 -> Пятьсот семьдесят девять");

    if(x ==580) Console.WriteLine("580 -> Пятьсот восемьдесят");
    if(x ==581) Console.WriteLine("581 -> Пятьсот восемьдесят один");
    if(x ==582) Console.WriteLine("582 -> Пятьсот восемьдесят два");
    if(x ==583) Console.WriteLine("583 -> Пятьсот восемьдесят три");
    if(x ==584) Console.WriteLine("584 -> Пятьсот восемьдесят четыре");
    if(x ==585) Console.WriteLine("585 -> Пятьсот восемьдесят пять");
    if(x ==586) Console.WriteLine("586 -> Пятьсот восемьдесят шесть");
    if(x ==587) Console.WriteLine("587 -> Пятьсот восемьдесят семь");
    if(x ==588) Console.WriteLine("588 -> Пятьсот восемьдесят восемь");
    if(x ==589) Console.WriteLine("589 -> Пятьсот восемьдесят девять");

    if(x ==590) Console.WriteLine("590 -> Пятьсот девяносто");
    if(x ==591) Console.WriteLine("591 -> Пятьсот девяносто один");
    if(x ==592) Console.WriteLine("592 -> Пятьсот девяносто два");
    if(x ==593) Console.WriteLine("593 -> Пятьсот девяносто три");
    if(x ==594) Console.WriteLine("594 -> Пятьсот девяносто четыре");
    if(x ==595) Console.WriteLine("595 -> Пятьсот девяносто пять");
    if(x ==596) Console.WriteLine("596 -> Пятьсот девяносто шесть");
    if(x ==597) Console.WriteLine("597 -> Пятьсот девяносто семь");
    if(x ==598) Console.WriteLine("598 -> Пятьсот девяносто восемь");
    if(x ==599) Console.WriteLine("599 -> Пятьсот девяносто девять");



     if(x ==600) Console.WriteLine("600 -> Шестьсот");
     if(x ==601) Console.WriteLine("601 -> Шестьсот один"); 
    if(x ==602) Console.WriteLine("602 -> Шестьсот два");
    if(x ==603) Console.WriteLine("603 -> Шестьсот три");
    if(x ==604) Console.WriteLine("604 -> Шестьсот четыре");
    if(x ==605) Console.WriteLine("605 -> Шестьсот пять");
    if(x ==606) Console.WriteLine("606 -> Шестьсот шесть");
    if(x ==607) Console.WriteLine("607 -> Шестьсот семь");
    if(x ==608) Console.WriteLine("608 -> Шестьсот восемь");
    if(x ==609) Console.WriteLine("609 -> Шестьсот девять");

    if(x ==610) Console.WriteLine("610 -> Шестьсот десять");
    if(x ==611) Console.WriteLine("611 -> Шестьсот одинадцать");
    if(x ==612) Console.WriteLine("612 -> Шестьсот двенадцать");
    if(x ==613) Console.WriteLine("613 -> Шестьсот тринадцать");
    if(x ==614) Console.WriteLine("614 -> Шестьсот четырнадцать");
    if(x ==615) Console.WriteLine("615 -> Шестьсот пятнадцать");
    if(x ==616) Console.WriteLine("616 -> Шестьсот шестнадцать");
    if(x ==617) Console.WriteLine("617 -> Шестьсот семнадцать");
    if(x ==618) Console.WriteLine("618 -> Шестьсот восемнадцать");
    if(x ==619) Console.WriteLine("619 -> Шестьсот девятнадцать");

    if(x ==620) Console.WriteLine("620 -> Шестьсот двадцать");
    if(x ==621) Console.WriteLine("621 -> Шестьсот двадцать один");
    if(x ==622) Console.WriteLine("622 -> Шестьсот двадцать два");
    if(x ==623) Console.WriteLine("623 -> Шестьсот двадцать три");
    if(x ==624) Console.WriteLine("624 -> Шестьсот двадцать четыре");
    if(x ==625) Console.WriteLine("625 -> Шестьсот двадцать пять");
    if(x ==626) Console.WriteLine("626 -> Шестьсот двадцать шесть");
    if(x ==627) Console.WriteLine("627 -> Шестьсот двадцать семь");
    if(x ==628) Console.WriteLine("628 -> Шестьсот двадцать восемь");
    if(x ==629) Console.WriteLine("629 -> Шестьсот двадцать девять");

     if(x ==630) Console.WriteLine("630 -> Шестьсот тридцать");
    if(x ==631) Console.WriteLine("631 -> Шестьсот тридцать один");
    if(x ==632) Console.WriteLine("632 -> Шестьсот тридцать два");
    if(x ==633) Console.WriteLine("633 -> Шестьсот тридцать три");
    if(x ==634) Console.WriteLine("634 -> Шестьсот тридцать четыре");
    if(x ==635) Console.WriteLine("635 -> Шестьсот тридцать пять");
    if(x ==636) Console.WriteLine("636 -> Шестьсот тридцать шесть");
    if(x ==637) Console.WriteLine("637 -> Шестьсот тридцать семь");
    if(x ==638) Console.WriteLine("638 -> Шестьсот тридцать восемь");
    if(x ==639) Console.WriteLine("639 -> Шестьсот тридцать девять");

    if(x ==640) Console.WriteLine("640 -> Шестьсот сорок");
    if(x ==641) Console.WriteLine("641 -> Шестьсот сорок один");
    if(x ==642) Console.WriteLine("642 -> Шестьсот тридцать два");
    if(x ==643) Console.WriteLine("643 -> Шестьсот тридцать три");
    if(x ==644) Console.WriteLine("644 -> Шестьсот тридцать четыре");
    if(x ==645) Console.WriteLine("645 -> Шестьсот тридцать пять");
    if(x ==646) Console.WriteLine("646 -> Шестьсот тридцать шесть");
    if(x ==647) Console.WriteLine("647 -> Шестьсот тридцать семь");
    if(x ==648) Console.WriteLine("648 -> Шестьсот тридцать восемь");
    if(x ==649) Console.WriteLine("649 -> Шестьсот тридцать девять");

    if(x ==650) Console.WriteLine("650 -> Шестьсот пятьдесят");
    if(x ==651) Console.WriteLine("651 -> Шестьсот пятьдесят один");
    if(x ==652) Console.WriteLine("652 -> Шестьсот пятьдесят два");
    if(x ==653) Console.WriteLine("653 -> Шестьсот пятьдесят три");
    if(x ==654) Console.WriteLine("654 -> Шестьсот пятьдесят четыре");
    if(x ==655) Console.WriteLine("655 -> Шестьсот пятьдесят пять");
    if(x ==656) Console.WriteLine("656 -> Шестьсот пятьдесят шесть");
    if(x ==657) Console.WriteLine("657 -> Шестьсот пятьдесят семь");
    if(x ==658) Console.WriteLine("658 -> Шестьсот пятьдесят восемь");
    if(x ==659) Console.WriteLine("659 -> Шестьсот пятьдесят девять");

    if(x ==660) Console.WriteLine("660 -> Шестьсот шестьдесят");
    if(x ==661) Console.WriteLine("661 -> Шестьсот шестьдесят один");
    if(x ==662) Console.WriteLine("662 -> Шестьсот шестьдесят два");
    if(x ==663) Console.WriteLine("663 -> Шестьсот шестьдесят три");
    if(x ==664) Console.WriteLine("664 -> Шестьсот шестьдесят четыре");
    if(x ==665) Console.WriteLine("665 -> Шестьсот шестьдесят пять");
    if(x ==666) Console.WriteLine("666 -> Шестьсот шестьдесят шесть");
    if(x ==667) Console.WriteLine("667 -> Шестьсот шестьдесят семь");
    if(x ==668) Console.WriteLine("668 -> Шестьсот шестьдесят восемь");
    if(x ==669) Console.WriteLine("669 -> Шестьсот шестьдесят девять");

    if(x ==670) Console.WriteLine("670 -> Шестьсот семьдесят");
    if(x ==671) Console.WriteLine("671 -> Шестьсот семьдесят один");
    if(x ==672) Console.WriteLine("672 -> Шестьсот семьдесят два");
    if(x ==673) Console.WriteLine("673 -> Шестьсот семьдесят три");
    if(x ==674) Console.WriteLine("674 -> Шестьсот семьдесят четыре");
    if(x ==675) Console.WriteLine("675 -> Шестьсот семьдесят пять");
    if(x ==676) Console.WriteLine("676 -> Шестьсот семьдесят шесть");
    if(x ==677) Console.WriteLine("677 -> Шестьсот семьдесят семь");
    if(x ==678) Console.WriteLine("678 -> Шестьсот семьдесят восемь");
    if(x ==679) Console.WriteLine("679 -> Шестьсот семьдесят девять");

    if(x ==680) Console.WriteLine("680 -> Шестьсот восемьдесят");
    if(x ==681) Console.WriteLine("681 -> Шестьсот восемьдесят один");
    if(x ==682) Console.WriteLine("682 -> Шестьсот восемьдесят два");
    if(x ==683) Console.WriteLine("683 -> Шестьсот восемьдесят три");
    if(x ==684) Console.WriteLine("684 -> Шестьсот восемьдесят четыре");
    if(x ==685) Console.WriteLine("685 -> Шестьсот восемьдесят пять");
    if(x ==686) Console.WriteLine("686 -> Шестьсот восемьдесят шесть");
    if(x ==687) Console.WriteLine("687 -> Шестьсот восемьдесят семь");
    if(x ==688) Console.WriteLine("688 -> Шестьсот восемьдесят восемь");
    if(x ==689) Console.WriteLine("689 -> Шестьсот восемьдесят девять");

    if(x ==690) Console.WriteLine("690 -> Шестьсот девяносто");
    if(x ==691) Console.WriteLine("691 -> Шестьсот девяносто один");
    if(x ==692) Console.WriteLine("692 -> Шестьсот девяносто два");
    if(x ==693) Console.WriteLine("693 -> Шестьсот девяносто три");
    if(x ==694) Console.WriteLine("694 -> Шестьсот девяносто четыре");
    if(x ==695) Console.WriteLine("695 -> Шестьсот девяносто пять");
    if(x ==696) Console.WriteLine("696 -> Шестьсот девяносто шесть");
    if(x ==697) Console.WriteLine("697 -> Шестьсот девяносто семь");
    if(x ==698) Console.WriteLine("698 -> Шестьсот девяносто восемь");
    if(x ==699) Console.WriteLine("699 -> Шестьсот девяносто девять");



     if(x ==700) Console.WriteLine("700 -> Семьсот");
     if(x ==701) Console.WriteLine("701 -> Семьсот один"); 
    if(x ==702) Console.WriteLine("702 -> Семьсот два");
    if(x ==703) Console.WriteLine("703 -> Семьсот три");
    if(x ==704) Console.WriteLine("704 -> Семьсот четыре");
    if(x ==705) Console.WriteLine("705 -> Семьсот пять");
    if(x ==706) Console.WriteLine("706 -> Семьсот шесть");
    if(x ==707) Console.WriteLine("707 -> Семьсот семь");
    if(x ==708) Console.WriteLine("708 -> Семьсот восемь");
    if(x ==709) Console.WriteLine("709 -> Семьсот девять");

    if(x ==710) Console.WriteLine("710 -> Семьсот десять");
    if(x ==711) Console.WriteLine("711 -> Семьсот одинадцать");
    if(x ==712) Console.WriteLine("712 -> Семьсот двенадцать");
    if(x ==713) Console.WriteLine("713 -> Семьсот тринадцать");
    if(x ==714) Console.WriteLine("714 -> Семьсот четырнадцать");
    if(x ==715) Console.WriteLine("715 -> Семьсот пятнадцать");
    if(x ==716) Console.WriteLine("716 -> Семьсот шестнадцать");
    if(x ==717) Console.WriteLine("717 -> Семьсот семнадцать");
    if(x ==718) Console.WriteLine("718 -> Семьсот восемнадцать");
    if(x ==719) Console.WriteLine("719 -> Семьсот девятнадцать");

    if(x ==720) Console.WriteLine("720 -> Семьсот двадцать");
    if(x ==721) Console.WriteLine("721 -> Семьсот двадцать один");
    if(x ==722) Console.WriteLine("722 -> Семьсот двадцать два");
    if(x ==723) Console.WriteLine("723 -> Семьсот двадцать три");
    if(x ==724) Console.WriteLine("724 -> Семьсот двадцать четыре");
    if(x ==725) Console.WriteLine("725 -> Семьсот двадцать пять");
    if(x ==726) Console.WriteLine("726 -> Семьсот двадцать шесть");
    if(x ==727) Console.WriteLine("727 -> Семьсот двадцать семь");
    if(x ==728) Console.WriteLine("728 -> Семьсот двадцать восемь");
    if(x ==729) Console.WriteLine("729 -> Семьсот двадцать девять");

     if(x ==730) Console.WriteLine("730 -> Семьсот тридцать");
    if(x ==731) Console.WriteLine("731 -> Семьсот тридцать один");
    if(x ==732) Console.WriteLine("732 -> Семьсот тридцать два");
    if(x ==733) Console.WriteLine("733 -> Семьсот тридцать три");
    if(x ==734) Console.WriteLine("734 -> Семьсот тридцать четыре");
    if(x ==735) Console.WriteLine("735 -> Семьсот тридцать пять");
    if(x ==736) Console.WriteLine("736 -> Семьсот тридцать шесть");
    if(x ==737) Console.WriteLine("737 -> Семьсот тридцать семь");
    if(x ==738) Console.WriteLine("738 -> Семьсот тридцать восемь");
    if(x ==739) Console.WriteLine("739 -> Семьсот тридцать девять");

    if(x ==740) Console.WriteLine("740 -> Семьсот сорок");
    if(x ==741) Console.WriteLine("741 -> Семьсот сорок один");
    if(x ==742) Console.WriteLine("742 -> Семьсот тридцать два");
    if(x ==743) Console.WriteLine("743 -> Семьсот тридцать три");
    if(x ==744) Console.WriteLine("744 -> Семьсот тридцать четыре");
    if(x ==745) Console.WriteLine("745 -> Семьсот тридцать пять");
    if(x ==746) Console.WriteLine("746 -> Семьсот тридцать шесть");
    if(x ==747) Console.WriteLine("747 -> Семьсот тридцать семь");
    if(x ==748) Console.WriteLine("748 -> Семьсот тридцать восемь");
    if(x ==749) Console.WriteLine("749 -> Семьсот тридцать девять");

    if(x ==750) Console.WriteLine("750 -> Семьсот пятьдесят");
    if(x ==751) Console.WriteLine("751 -> Семьсот пятьдесят один");
    if(x ==752) Console.WriteLine("752 -> Семьсот пятьдесят два");
    if(x ==753) Console.WriteLine("753 -> Семьсот пятьдесят три");
    if(x ==754) Console.WriteLine("754 -> Семьсот пятьдесят четыре");
    if(x ==755) Console.WriteLine("755 -> Семьсот пятьдесят пять");
    if(x ==756) Console.WriteLine("756 -> Семьсот пятьдесят шесть");
    if(x ==757) Console.WriteLine("757 -> Семьсот пятьдесят семь");
    if(x ==758) Console.WriteLine("758 -> Семьсот пятьдесят восемь");
    if(x ==759) Console.WriteLine("759 -> Семьсот пятьдесят девять");

    if(x ==760) Console.WriteLine("760 -> Семьсот шестьдесят");
    if(x ==761) Console.WriteLine("761 -> Семьсот шестьдесят один");
    if(x ==762) Console.WriteLine("762 -> Семьсот шестьдесят два");
    if(x ==763) Console.WriteLine("763 -> Семьсот шестьдесят три");
    if(x ==764) Console.WriteLine("764 -> Семьсот шестьдесят четыре");
    if(x ==765) Console.WriteLine("765 -> Семьсот шестьдесят пять");
    if(x ==766) Console.WriteLine("766 -> Семьсот шестьдесят шесть");
    if(x ==767) Console.WriteLine("767 -> Семьсот шестьдесят семь");
    if(x ==768) Console.WriteLine("768 -> Семьсот шестьдесят восемь");
    if(x ==769) Console.WriteLine("769 -> Семьсот шестьдесят девять");

    if(x ==770) Console.WriteLine("770 -> Семьсот семьдесят");
    if(x ==771) Console.WriteLine("771 -> Семьсот семьдесят один");
    if(x ==772) Console.WriteLine("772 -> Семьсот семьдесят два");
    if(x ==773) Console.WriteLine("773 -> Семьсот семьдесят три");
    if(x ==774) Console.WriteLine("774 -> Семьсот семьдесят четыре");
    if(x ==775) Console.WriteLine("775 -> Семьсот семьдесят пять");
    if(x ==776) Console.WriteLine("776 -> Семьсот семьдесят шесть");
    if(x ==777) Console.WriteLine("777 -> Семьсот семьдесят семь");
    if(x ==778) Console.WriteLine("778 -> Семьсот семьдесят восемь");
    if(x ==779) Console.WriteLine("779 -> Семьсот семьдесят девять");

    if(x ==780) Console.WriteLine("780 -> Семьсот восемьдесят");
    if(x ==781) Console.WriteLine("781 -> Семьсот восемьдесят один");
    if(x ==782) Console.WriteLine("782 -> Семьсот восемьдесят два");
    if(x ==783) Console.WriteLine("783 -> Семьсот восемьдесят три");
    if(x ==784) Console.WriteLine("784 -> Семьсот восемьдесят четыре");
    if(x ==785) Console.WriteLine("785 -> Семьсот восемьдесят пять");
    if(x ==786) Console.WriteLine("786 -> Семьсот восемьдесят шесть");
    if(x ==787) Console.WriteLine("787 -> Семьсот восемьдесят семь");
    if(x ==788) Console.WriteLine("788 -> Семьсот восемьдесят восемь");
    if(x ==789) Console.WriteLine("789 -> Семьсот восемьдесят девять");

    if(x ==790) Console.WriteLine("790 -> Семьсот девяносто");
    if(x ==791) Console.WriteLine("791 -> Семьсот девяносто один");
    if(x ==792) Console.WriteLine("792 -> Семьсот девяносто два");
    if(x ==793) Console.WriteLine("793 -> Семьсот девяносто три");
    if(x ==794) Console.WriteLine("794 -> Семьсот девяносто четыре");
    if(x ==795) Console.WriteLine("795 -> Семьсот девяносто пять");
    if(x ==796) Console.WriteLine("796 -> Семьсот девяносто шесть");
    if(x ==797) Console.WriteLine("797 -> Семьсот девяносто семь");
    if(x ==798) Console.WriteLine("798 -> Семьсот девяносто восемь");
    if(x ==799) Console.WriteLine("799 -> Семьсот девяносто девять");



    if(x ==800) Console.WriteLine("800 -> Восемьсот");
    if(x ==801) Console.WriteLine("801 -> Восемьсот один"); 
    if(x ==802) Console.WriteLine("802 -> Восемьсот два");
    if(x ==803) Console.WriteLine("803 -> Восемьсот три");
    if(x ==804) Console.WriteLine("804 -> Восемьсот четыре");
    if(x ==805) Console.WriteLine("805 -> Восемьсот пять");
    if(x ==806) Console.WriteLine("806 -> Восемьсот шесть");
    if(x ==807) Console.WriteLine("807 -> Восемьсот семь");
    if(x ==808) Console.WriteLine("808 -> Восемьсот восемь");
    if(x ==809) Console.WriteLine("809 -> Восемьсот девять");

    if(x ==810) Console.WriteLine("810 -> Восемьсот десять");
    if(x ==811) Console.WriteLine("811 -> Восемьсот одинадцать");
    if(x ==812) Console.WriteLine("812 -> Восемьсот двенадцать");
    if(x ==813) Console.WriteLine("813 -> Восемьсот тринадцать");
    if(x ==814) Console.WriteLine("814 -> Восемьсот четырнадцать");
    if(x ==815) Console.WriteLine("815 -> Восемьсот пятнадцать");
    if(x ==816) Console.WriteLine("816 -> Восемьсот шестнадцать");
    if(x ==817) Console.WriteLine("817 -> Восемьсот семнадцать");
    if(x ==818) Console.WriteLine("818 -> Восемьсот восемнадцать");
    if(x ==819) Console.WriteLine("819 -> Восемьсот девятнадцать");

    if(x ==820) Console.WriteLine("820 -> Восемьсот двадцать");
    if(x ==821) Console.WriteLine("821 -> Восемьсот двадцать один");
    if(x ==822) Console.WriteLine("822 -> Восемьсот двадцать два");
    if(x ==823) Console.WriteLine("823 -> Восемьсот двадцать три");
    if(x ==824) Console.WriteLine("824 -> Восемьсот двадцать четыре");
    if(x ==825) Console.WriteLine("825 -> Восемьсот двадцать пять");
    if(x ==826) Console.WriteLine("826 -> Восемьсот двадцать шесть");
    if(x ==827) Console.WriteLine("827 -> Восемьсот двадцать семь");
    if(x ==828) Console.WriteLine("828 -> Восемьсот двадцать восемь");
    if(x ==829) Console.WriteLine("829 -> Восемьсот двадцать девять");

    if(x ==830) Console.WriteLine("830 -> Восемьсот тридцать");
    if(x ==831) Console.WriteLine("831 -> Восемьсот тридцать один");
    if(x ==832) Console.WriteLine("832 -> Восемьсот тридцать два");
    if(x ==833) Console.WriteLine("833 -> Восемьсот тридцать три");
    if(x ==834) Console.WriteLine("834 -> Восемьсот тридцать четыре");
    if(x ==835) Console.WriteLine("835 -> Восемьсот тридцать пять");
    if(x ==836) Console.WriteLine("836 -> Восемьсот тридцать шесть");
    if(x ==837) Console.WriteLine("837 -> Восемьсот тридцать семь");
    if(x ==838) Console.WriteLine("838 -> Восемьсот тридцать восемь");
    if(x ==839) Console.WriteLine("839 -> Восемьсот тридцать девять");

    if(x ==840) Console.WriteLine("840 -> Восемьсот сорок");
    if(x ==841) Console.WriteLine("841 -> Восемьсот сорок один");
    if(x ==842) Console.WriteLine("842 -> Восемьсот тридцать два");
    if(x ==843) Console.WriteLine("843 -> Восемьсот тридцать три");
    if(x ==844) Console.WriteLine("844 -> Восемьсот тридцать четыре");
    if(x ==845) Console.WriteLine("845 -> Восемьсот тридцать пять");
    if(x ==846) Console.WriteLine("846 -> Восемьсот тридцать шесть");
    if(x ==847) Console.WriteLine("847 -> Восемьсот тридцать семь");
    if(x ==848) Console.WriteLine("848 -> Восемьсот тридцать восемь");
    if(x ==849) Console.WriteLine("849 -> Восемьсот тридцать девять");

    if(x ==850) Console.WriteLine("850 -> Восемьсот пятьдесят");
    if(x ==851) Console.WriteLine("851 -> Восемьсот пятьдесят один");
    if(x ==852) Console.WriteLine("852 -> Восемьсот пятьдесят два");
    if(x ==853) Console.WriteLine("853 -> Восемьсот пятьдесят три");
    if(x ==854) Console.WriteLine("854 -> Восемьсот пятьдесят четыре");
    if(x ==855) Console.WriteLine("855 -> Восемьсот пятьдесят пять");
    if(x ==856) Console.WriteLine("856 -> Восемьсот пятьдесят шесть");
    if(x ==857) Console.WriteLine("857 -> Восемьсот пятьдесят семь");
    if(x ==858) Console.WriteLine("858 -> Восемьсот пятьдесят восемь");
    if(x ==859) Console.WriteLine("859 -> Восемьсот пятьдесят девять");

    if(x ==860) Console.WriteLine("860 -> Восемьсот шестьдесят");
    if(x ==861) Console.WriteLine("861 -> Восемьсот шестьдесят один");
    if(x ==862) Console.WriteLine("862 -> Восемьсот шестьдесят два");
    if(x ==863) Console.WriteLine("863 -> Восемьсот шестьдесят три");
    if(x ==864) Console.WriteLine("864 -> Восемьсот шестьдесят четыре");
    if(x ==865) Console.WriteLine("865 -> Восемьсот шестьдесят пять");
    if(x ==866) Console.WriteLine("866 -> Восемьсот шестьдесят шесть");
    if(x ==867) Console.WriteLine("867 -> Восемьсот шестьдесят семь");
    if(x ==868) Console.WriteLine("868 -> Восемьсот шестьдесят восемь");
    if(x ==869) Console.WriteLine("869 -> Восемьсот шестьдесят девять");

    if(x ==870) Console.WriteLine("870 -> Восемьсот семьдесят");
    if(x ==871) Console.WriteLine("871 -> Восемьсот семьдесят один");
    if(x ==872) Console.WriteLine("872 -> Восемьсот семьдесят два");
    if(x ==873) Console.WriteLine("873 -> Восемьсот семьдесят три");
    if(x ==874) Console.WriteLine("874 -> Восемьсот семьдесят четыре");
    if(x ==875) Console.WriteLine("875 -> Восемьсот семьдесят пять");
    if(x ==876) Console.WriteLine("876 -> Восемьсот семьдесят шесть");
    if(x ==877) Console.WriteLine("877 -> Восемьсот семьдесят семь");
    if(x ==878) Console.WriteLine("878 -> Восемьсот семьдесят восемь");
    if(x ==879) Console.WriteLine("879 -> Восемьсот семьдесят девять");

    if(x ==880) Console.WriteLine("880 -> Восемьсот восемьдесят");
    if(x ==881) Console.WriteLine("881 -> Восемьсот восемьдесят один");
    if(x ==882) Console.WriteLine("882 -> Восемьсот восемьдесят два");
    if(x ==883) Console.WriteLine("883 -> Восемьсот восемьдесят три");
    if(x ==884) Console.WriteLine("884 -> Восемьсот восемьдесят четыре");
    if(x ==885) Console.WriteLine("885 -> Восемьсот восемьдесят пять");
    if(x ==886) Console.WriteLine("886 -> Восемьсот восемьдесят шесть");
    if(x ==887) Console.WriteLine("887 -> Восемьсот восемьдесят семь");
    if(x ==888) Console.WriteLine("888 -> Восемьсот восемьдесят восемь");
    if(x ==889) Console.WriteLine("889 -> Восемьсот восемьдесят девять");

    if(x ==890) Console.WriteLine("890 -> Восемьсот девяносто");
    if(x ==891) Console.WriteLine("891 -> Восемьсот девяносто один");
    if(x ==892) Console.WriteLine("892 -> Восемьсот девяносто два");
    if(x ==893) Console.WriteLine("893 -> Восемьсот девяносто три");
    if(x ==894) Console.WriteLine("894 -> Восемьсот девяносто четыре");
    if(x ==895) Console.WriteLine("895 -> Восемьсот девяносто пять");
    if(x ==896) Console.WriteLine("896 -> Восемьсот девяносто шесть");
    if(x ==897) Console.WriteLine("897 -> Восемьсот девяносто семь");
    if(x ==898) Console.WriteLine("898 -> Восемьсот девяносто восемь");
    if(x ==899) Console.WriteLine("899 -> Восемьсот девяносто девять");



    if(x ==900) Console.WriteLine("900 -> Девятьсот");
    if(x ==901) Console.WriteLine("901 -> Девятьсот один"); 
    if(x ==902) Console.WriteLine("902 -> Девятьсот два");
    if(x ==903) Console.WriteLine("903 -> Девятьсот три");
    if(x ==904) Console.WriteLine("904 -> Девятьсот четыре");
    if(x ==905) Console.WriteLine("905 -> Девятьсот пять");
    if(x ==906) Console.WriteLine("906 -> Девятьсот шесть");
    if(x ==907) Console.WriteLine("907 -> Девятьсот семь");
    if(x ==908) Console.WriteLine("908 -> Девятьсот восемь");
    if(x ==909) Console.WriteLine("909 -> Девятьсот девять");

    if(x ==910) Console.WriteLine("910 -> Девятьсот десять");
    if(x ==911) Console.WriteLine("911 -> Девятьсот одинадцать");
    if(x ==912) Console.WriteLine("912 -> Девятьсот двенадцать");
    if(x ==913) Console.WriteLine("913 -> Девятьсот тринадцать");
    if(x ==914) Console.WriteLine("914 -> Девятьсот четырнадцать");
    if(x ==915) Console.WriteLine("915 -> Девятьсот пятнадцать");
    if(x ==916) Console.WriteLine("916 -> Девятьсот шестнадцать");
    if(x ==917) Console.WriteLine("917 -> Девятьсот семнадцать");
    if(x ==918) Console.WriteLine("918 -> Девятьсот восемнадцать");
    if(x ==919) Console.WriteLine("919 -> Девятьсот девятнадцать");

    if(x ==920) Console.WriteLine("920 -> Девятьсот двадцать");
    if(x ==921) Console.WriteLine("921 -> Девятьсот двадцать один");
    if(x ==922) Console.WriteLine("922 -> Девятьсот двадцать два");
    if(x ==923) Console.WriteLine("923 -> Девятьсот двадцать три");
    if(x ==924) Console.WriteLine("924 -> Девятьсот двадцать четыре");
    if(x ==925) Console.WriteLine("925 -> Девятьсот двадцать пять");
    if(x ==926) Console.WriteLine("926 -> Девятьсот двадцать шесть");
    if(x ==927) Console.WriteLine("927 -> Девятьсот двадцать семь");
    if(x ==928) Console.WriteLine("928 -> Девятьсот двадцать восемь");
    if(x ==929) Console.WriteLine("929 -> Девятьсот двадцать девять");

    if(x ==930) Console.WriteLine("930 -> Девятьсот тридцать");
    if(x ==931) Console.WriteLine("931 -> Девятьсот тридцать один");
    if(x ==932) Console.WriteLine("932 -> Девятьсот тридцать два");
    if(x ==933) Console.WriteLine("933 -> Девятьсот тридцать три");
    if(x ==934) Console.WriteLine("934 -> Девятьсот тридцать четыре");
    if(x ==935) Console.WriteLine("935 -> Девятьсот тридцать пять");
    if(x ==936) Console.WriteLine("936 -> Девятьсот тридцать шесть");
    if(x ==937) Console.WriteLine("937 -> Девятьсот тридцать семь");
    if(x ==938) Console.WriteLine("938 -> Девятьсот тридцать восемь");
    if(x ==939) Console.WriteLine("939 -> Девятьсот тридцать девять");

    if(x ==940) Console.WriteLine("940 -> Девятьсот сорок");
    if(x ==941) Console.WriteLine("941 -> Девятьсот сорок один");
    if(x ==942) Console.WriteLine("942 -> Девятьсот тридцать два");
    if(x ==943) Console.WriteLine("943 -> Девятьсот тридцать три");
    if(x ==944) Console.WriteLine("944 -> Девятьсот тридцать четыре");
    if(x ==945) Console.WriteLine("945 -> Девятьсот тридцать пять");
    if(x ==946) Console.WriteLine("946 -> Девятьсот тридцать шесть");
    if(x ==947) Console.WriteLine("947 -> Девятьсот тридцать семь");
    if(x ==948) Console.WriteLine("948 -> Девятьсот тридцать восемь");
    if(x ==949) Console.WriteLine("949 -> Девятьсот тридцать девять");

    if(x ==950) Console.WriteLine("950 -> Девятьсот пятьдесят");
    if(x ==951) Console.WriteLine("951 -> Девятьсот пятьдесят один");
    if(x ==952) Console.WriteLine("952 -> Девятьсот пятьдесят два");
    if(x ==953) Console.WriteLine("953 -> Девятьсот пятьдесят три");
    if(x ==954) Console.WriteLine("954 -> Девятьсот пятьдесят четыре");
    if(x ==955) Console.WriteLine("955 -> Девятьсот пятьдесят пять");
    if(x ==956) Console.WriteLine("956 -> Девятьсот пятьдесят шесть");
    if(x ==957) Console.WriteLine("957 -> Девятьсот пятьдесят семь");
    if(x ==958) Console.WriteLine("958 -> Девятьсот пятьдесят восемь");
    if(x ==959) Console.WriteLine("959 -> Девятьсот пятьдесят девять");

    if(x ==960) Console.WriteLine("960 -> Девятьсот шестьдесят");
    if(x ==961) Console.WriteLine("961 -> Девятьсот шестьдесят один");
    if(x ==962) Console.WriteLine("962 -> Девятьсот шестьдесят два");
    if(x ==963) Console.WriteLine("963 -> Девятьсот шестьдесят три");
    if(x ==964) Console.WriteLine("964 -> Девятьсот шестьдесят четыре");
    if(x ==965) Console.WriteLine("965 -> Девятьсот шестьдесят пять");
    if(x ==966) Console.WriteLine("966 -> Девятьсот шестьдесят шесть");
    if(x ==967) Console.WriteLine("967 -> Девятьсот шестьдесят семь");
    if(x ==968) Console.WriteLine("968 -> Девятьсот шестьдесят восемь");
    if(x ==969) Console.WriteLine("969 -> Девятьсот шестьдесят девять");

    if(x ==970) Console.WriteLine("970 -> Девятьсот семьдесят");
    if(x ==971) Console.WriteLine("971 -> Девятьсот семьдесят один");
    if(x ==972) Console.WriteLine("972 -> Девятьсот семьдесят два");
    if(x ==973) Console.WriteLine("973 -> Девятьсот семьдесят три");
    if(x ==974) Console.WriteLine("974 -> Девятьсот семьдесят четыре");
    if(x ==975) Console.WriteLine("975 -> Девятьсот семьдесят пять");
    if(x ==976) Console.WriteLine("976 -> Девятьсот семьдесят шесть");
    if(x ==977) Console.WriteLine("977 -> Девятьсот семьдесят семь");
    if(x ==978) Console.WriteLine("978 -> Девятьсот семьдесят восемь");
    if(x ==979) Console.WriteLine("979 -> Девятьсот семьдесят девять");

    if(x ==980) Console.WriteLine("980 -> Девятьсот восемьдесят");
    if(x ==981) Console.WriteLine("981 -> Девятьсот восемьдесят один");
    if(x ==982) Console.WriteLine("982 -> Девятьсот восемьдесят два");
    if(x ==983) Console.WriteLine("983 -> Девятьсот восемьдесят три");
    if(x ==984) Console.WriteLine("984 -> Девятьсот восемьдесят четыре");
    if(x ==985) Console.WriteLine("985 -> Девятьсот восемьдесят пять");
    if(x ==986) Console.WriteLine("986 -> Девятьсот восемьдесят шесть");
    if(x ==987) Console.WriteLine("987 -> Девятьсот восемьдесят семь");
    if(x ==988) Console.WriteLine("988 -> Девятьсот восемьдесят восемь");
    if(x ==989) Console.WriteLine("989 -> Девятьсот восемьдесят девять");

    if(x ==990) Console.WriteLine("990 -> Девятьсот девяносто");
    if(x ==991) Console.WriteLine("991 -> Девятьсот девяносто один");
    if(x ==992) Console.WriteLine("992 -> Девятьсот девяносто два");
    if(x ==993) Console.WriteLine("993 -> Девятьсот девяносто три");
    if(x ==994) Console.WriteLine("994 -> Девятьсот девяносто четыре");
    if(x ==995) Console.WriteLine("995 -> Девятьсот девяносто пять");
    if(x ==996) Console.WriteLine("996 -> Девятьсот девяносто шесть");
    if(x ==997) Console.WriteLine("997 -> Девятьсот девяносто семь");
    if(x ==998) Console.WriteLine("998 -> Девятьсот девяносто восемь");
    if(x ==999) Console.WriteLine("999 -> Девятьсот девяносто девять");
}
    if(x ==1000) Console.WriteLine("1000 -> Тысяча");
    if(x == 10000||x > 10000) Console.WriteLine("10000 => Десять тысяч");








