DELETE FROM `Voelker`;

INSERT INTO `Voelker`(`Volkname`)
              VALUES ('Mensch'  ),
                     ('Elf'     ),
                     ('Zwerg'   );

DELETE FROM `Nachnamen` WHERE `Volkname` = 'Mensch';

INSERT INTO `Nachnamen`(`Volkname`, `Name`          )
                VALUES ('Mensch'  , 'Danamark'      ),
                       ('Mensch'  , 'Ballard'       ),
                       ('Mensch'  , 'Cromdor'       ),
                       ('Mensch'  , 'Bellto'        ),
                       ('Mensch'  , 'Embers'        ),
                       ('Mensch'  , 'Fallenbridge'  ),
                       ('Mensch'  , 'Gresser'       ),
                       ('Mensch'  , 'Weaver'        ),
                       ('Mensch'  , 'Fletcher'      ),
                       ('Mensch'  , 'Cathloy'       ),
                       ('Mensch'  , 'Belet'         ),
                       ('Mensch'  , 'Poortstag'     ),
                       ('Mensch'  , 'Swiller'       ),
                       ('Mensch'  , 'Oberheilm'     ),
                       ('Mensch'  , 'Stavenger'     ),
                       ('Mensch'  , 'Frost'         ),
                       ('Mensch'  , 'Sutton'        ),
                       ('Mensch'  , 'Blackstrand'   ),
                       ('Mensch'  , 'Hawk'          ),
                       ('Mensch'  , 'Greenbolt'     ),
                       ('Mensch'  , 'Altard'        ),
                       ('Mensch'  , 'Hornraven'     ),
                       ('Mensch'  , 'Kroft'         ),
                       ('Mensch'  , 'Roxley'        ),
                       ('Mensch'  , 'Oxborn'        ),
                       ('Mensch'  , 'Revenmar'      ),
                       ('Mensch'  , 'Pashar'        ),
                       ('Mensch'  , 'Silvergraft'   ),
                       ('Mensch'  , 'Redwald'       ),
                       ('Mensch'  , 'Keppler'       ),
                       ('Mensch'  , 'Milton'        ),
                       ('Mensch'  , 'Rowland'       ),
                       ('Mensch'  , 'Woller'        ),
                       ('Mensch'  , 'Beck'          ),
                       ('Mensch'  , 'Dalton'        ),
                       ('Mensch'  , 'Bigot'         ),
                       ('Mensch'  , 'Brightwater'   ),
                       ('Mensch'  , 'Prestcote'     ),
                       ('Mensch'  , 'Wilxes'        ),
                       ('Mensch'  , 'Addams'        );

DELETE FROM `Nachnamen` WHERE `Volkname` = 'Elf';

INSERT INTO `Nachnamen`(`Volkname`, `Name`          )
                VALUES ('Elf'     , 'Liadon'        ),
                       ('Elf'     , 'Korianthil'    ),
                       ('Elf'     , 'Gourael'       ),
                       ('Elf'     , 'Furivel'       ),
                       ('Elf'     , 'lphelkiir'     ),
                       ('Elf'     , 'Derunadel'     ),
                       ('Elf'     , 'Meliamne'      ),
                       ('Elf'     , 'Ellarian'      ),
                       ('Elf'     , 'Amakiir'       ),
                       ('Elf'     , 'Naerdre'       ),
                       ('Elf'     , 'Alanadel'      ),
                       ('Elf'     , 'Calaudra'      ),
                       ('Elf'     , 'Haladar'       ),
                       ('Elf'     , 'Teshurr'       ),
                       ('Elf'     , 'Clatharal'     ),
                       ('Elf'     , 'Irian'         ),
                       ('Elf'     , 'Mhaarm'        ),
                       ('Elf'     , 'Talandren'     ),
                       ('Elf'     , 'Haell'         ),
                       ('Elf'     , 'Nyntynel'      ),
                       ('Elf'     , 'Falanae'       ),
                       ('Elf'     , 'Meirityn'      ),
                       ('Elf'     , 'Larathian'     ),
                       ('Elf'     , 'Levanadel'     ),
                       ('Elf'     , 'Sinaran'       ),
                       ('Elf'     , 'Lundlar'       ),
                       ('Elf'     , 'Eyrindo'       ),
                       ('Elf'     , 'Erevyn'        ),
                       ('Elf'     , 'Agrivar'       ),
                       ('Elf'     , 'Maerdrym'      ),
                       ('Elf'     , 'Filiadir'      ),
                       ('Elf'     , 'Ildroun'       ),
                       ('Elf'     , 'Aendryr'       ),
                       ('Elf'     , 'Harithyn'      ),
                       ('Elf'     , 'Harimlur'      ),
                       ('Elf'     , 'Galanodel'     ),
                       ('Elf'     , 'Selorn'        ),
                       ('Elf'     , 'Ulongyr'       ),
                       ('Elf'     , 'Raedrim'       );

DELETE FROM `Nachnamen` WHERE `Volkname` = 'Zwerg';

INSERT INTO `Nachnamen`(`Volkname`, `Name`          )
                VALUES ('Zwerg'   , 'Silvertarn'    ),
                       ('Zwerg'   , 'Ironhelm'      ),
                       ('Zwerg'   , 'Voldort'       ),
                       ('Zwerg'   , 'Ironhand'      ),
                       ('Zwerg'   , 'Hammerfist'    ),
                       ('Zwerg'   , 'Ungart'        ),
                       ('Zwerg'   , 'Feldrikk'      ),
                       ('Zwerg'   , 'Wolfhame'      ),
                       ('Zwerg'   , 'Hardak'        ),
                       ('Zwerg'   , 'Nordar'        ),
                       ('Zwerg'   , 'Norrak'        ),
                       ('Zwerg'   , 'Axebite'       ),
                       ('Zwerg'   , 'Shuldek'       ),
                       ('Zwerg'   , 'Fadenheim'     ),
                       ('Zwerg'   , 'Loderr'        ),
                       ('Zwerg'   , 'Redbeard'      ),
                       ('Zwerg'   , 'Gorunn'        ),
                       ('Zwerg'   , 'Kragenar'      ),
                       ('Zwerg'   , 'Henchikk'      ),
                       ('Zwerg'   , 'Ramcrow'       ),
                       ('Zwerg'   , 'Sabreheim'     ),
                       ('Zwerg'   , 'Grayhammer'    ),
                       ('Zwerg'   , 'Paradur'       ),
                       ('Zwerg'   , 'Korvat'        ),
                       ('Zwerg'   , 'Strakeln'      ),
                       ('Zwerg'   , 'Stoneshield'   ),
                       ('Zwerg'   , 'Creegan'       ),
                       ('Zwerg'   , 'Dankil'        ),
                       ('Zwerg'   , 'Kreilun'       ),
                       ('Zwerg'   , 'Toldun'        ),
                       ('Zwerg'   , 'Avenigart'     ),
                       ('Zwerg'   , 'Zarkanan'      ),
                       ('Zwerg'   , 'Stonecrusher'  ),
                       ('Zwerg'   , 'Halor'         ),
                       ('Zwerg'   , 'Deepmiddens'   ),
                       ('Zwerg'   , 'Falbor'        ),
                       ('Zwerg'   , 'Jendor'        ),
                       ('Zwerg'   , 'Hackshield'    ),
                       ('Zwerg'   , 'Klorda'        ),
                       ('Zwerg'   , 'Vultheim'      );

DELETE FROM `Vornamen` 
      WHERE `Volkname`   = 'Mensch' 
        AND `Geschlecht` = 'M';

INSERT INTO `Vornamen`(`Volkname`, `Geschlecht`, `Name`     )
               VALUES ('Mensch'  , 'M'         , 'Morgan'   ),
                      ('Mensch'  , 'M'         , 'Drew'     ),
                      ('Mensch'  , 'M'         , 'Lander'   ),
                      ('Mensch'  , 'M'         , 'Alek'     ),
                      ('Mensch'  , 'M'         , 'Belmont'  ),
                      ('Mensch'  , 'M'         , 'Edwin'    ),
                      ('Mensch'  , 'M'         , 'Thom'     ),
                      ('Mensch'  , 'M'         , 'Darvan'   ),
                      ('Mensch'  , 'M'         , 'Daylen'   ),
                      ('Mensch'  , 'M'         , 'Benn'     ),
                      ('Mensch'  , 'M'         , 'Ander'    ),
                      ('Mensch'  , 'M'         , 'Eilif'    ),
                      ('Mensch'  , 'M'         , 'Dexter'   ),
                      ('Mensch'  , 'M'         , 'Menas'    ),
                      ('Mensch'  , 'M'         , 'Krynt'    ),
                      ('Mensch'  , 'M'         , 'Wayne'    ),
                      ('Mensch'  , 'M'         , 'Randall'  ),
                      ('Mensch'  , 'M'         , 'Kain'     ),
                      ('Mensch'  , 'M'         , 'Cale'     ),
                      ('Mensch'  , 'M'         , 'Tilton'   );

DELETE FROM `Vornamen` 
      WHERE `Volkname`   = 'Mensch' 
        AND `Geschlecht` = 'W';

INSERT INTO `Vornamen`(`Volkname`, `Geschlecht`, `Name`     )
               VALUES ('Mensch'  , 'W'         , 'Immith'   ),
                      ('Mensch'  , 'W'         , 'Giselle'  ),
                      ('Mensch'  , 'W'         , 'Ariana'   ),
                      ('Mensch'  , 'W'         , 'Tanika'   ),
                      ('Mensch'  , 'W'         , 'Radella'  ),
                      ('Mensch'  , 'W'         , 'Letita'   ),
                      ('Mensch'  , 'W'         , 'Casandra' ),
                      ('Mensch'  , 'W'         , 'Amelia'   ),
                      ('Mensch'  , 'W'         , 'Natali'   ),
                      ('Mensch'  , 'W'         , 'Katelyn'  ),
                      ('Mensch'  , 'W'         , 'Linette'  ),
                      ('Mensch'  , 'W'         , 'Avery'    ),
                      ('Mensch'  , 'W'         , 'Annabel'  ),
                      ('Mensch'  , 'W'         , 'Luusi'    ),
                      ('Mensch'  , 'W'         , 'Mara'     ),
                      ('Mensch'  , 'W'         , 'Hiriko'   ),
                      ('Mensch'  , 'W'         , 'Ursula'   ),
                      ('Mensch'  , 'W'         , 'Faila'    ),
                      ('Mensch'  , 'W'         , 'Alethra'  ),
                      ('Mensch'  , 'W'         , 'Tana'     );

DELETE FROM `Vornamen` 
      WHERE `Volkname`   = 'Elf' 
        AND `Geschlecht` = 'M';

INSERT INTO `Vornamen`(`Volkname`, `Geschlecht`, `Name`     )
               VALUES ('Elf'     , 'M'         , 'Ralnor'   ),
                      ('Elf'     , 'M'         , 'Celedor'  ),
                      ('Elf'     , 'M'         , 'Elyndar'  ),
                      ('Elf'     , 'M'         , 'Amyr'     ),
                      ('Elf'     , 'M'         , 'Nyalsir'  ),
                      ('Elf'     , 'M'         , 'Ariandar' ),
                      ('Elf'     , 'M'         , 'Reuel'    ),
                      ('Elf'     , 'M'         , 'Bellas'   ),
                      ('Elf'     , 'M'         , 'Laethan'  ),
                      ('Elf'     , 'M'         , 'Vaeril'   ),
                      ('Elf'     , 'M'         , 'Glorendil'),
                      ('Elf'     , 'M'         , 'Ellisar'  ),
                      ('Elf'     , 'M'         , 'Roedyn'   ),
                      ('Elf'     , 'M'         , 'Cindor'   ),
                      ('Elf'     , 'M'         , 'Gelduin'  ),
                      ('Elf'     , 'M'         , 'Andronel' ),
                      ('Elf'     , 'M'         , 'Mindartis'),
                      ('Elf'     , 'M'         , 'Evaryan'  ),
                      ('Elf'     , 'M'         , 'Ethrion'  ),
                      ('Elf'     , 'M'         , 'Drathuil' );

DELETE FROM `Vornamen` 
      WHERE `Volkname`   = 'Elf' 
        AND `Geschlecht` = 'W';

INSERT INTO `Vornamen`(`Volkname`, `Geschlecht`, `Name`     )
               VALUES ('Elf'     , 'W'         , 'Syndra'   ),
                      ('Elf'     , 'W'         , 'Leshanna' ),
                      ('Elf'     , 'W'         , 'Alloralla'),
                      ('Elf'     , 'W'         , 'Alagossa' ),
                      ('Elf'     , 'W'         , 'Jathal'   ),
                      ('Elf'     , 'W'         , 'Talindra' ),
                      ('Elf'     , 'W'         , 'Thia'     ),
                      ('Elf'     , 'W'         , 'Alavara'  ),
                      ('Elf'     , 'W'         , 'Filaurel' ),
                      ('Elf'     , 'W'         , 'Aneirin'  ),
                      ('Elf'     , 'W'         , 'Valindra' ),
                      ('Elf'     , 'W'         , 'Esta'     ),
                      ('Elf'     , 'W'         , 'Milena'   ),
                      ('Elf'     , 'W'         , 'Tiatha'   ),
                      ('Elf'     , 'W'         , 'Arylla'   ),
                      ('Elf'     , 'W'         , 'Valenthe' ),
                      ('Elf'     , 'W'         , 'Lyfalia'  ),
                      ('Elf'     , 'W'         , 'Ara'      ),
                      ('Elf'     , 'W'         , 'Ilyrana'  ),
                      ('Elf'     , 'W'         , 'Kavarala' );

DELETE FROM `Vornamen` 
      WHERE `Volkname`   = 'Zwerg' 
        AND `Geschlecht` = 'M';

INSERT INTO `Vornamen`(`Volkname`, `Geschlecht`, `Name`     )
               VALUES ('Zwerg'   , 'M'         , 'Dolmen'   ),
                      ('Zwerg'   , 'M'         , 'Orsik'    ),
                      ('Zwerg'   , 'M'         , 'Balnur'   ),
                      ('Zwerg'   , 'M'         , 'Rangrim'  ),
                      ('Zwerg'   , 'M'         , 'Flint'    ),
                      ('Zwerg'   , 'M'         , 'Kilgur'   ),
                      ('Zwerg'   , 'M'         , 'Thorgrim' ),
                      ('Zwerg'   , 'M'         , 'Tredigar' ),
                      ('Zwerg'   , 'M'         , 'Grunyar'  ),
                      ('Zwerg'   , 'M'         , 'Garmul'   ),
                      ('Zwerg'   , 'M'         , 'Taldak'   ),
                      ('Zwerg'   , 'M'         , 'Brottor'  ),
                      ('Zwerg'   , 'M'         , 'Adrik'    ),
                      ('Zwerg'   , 'M'         , 'Thorin'   ),
                      ('Zwerg'   , 'M'         , 'Vondral'  ),
                      ('Zwerg'   , 'M'         , 'Grimrak'  ),
                      ('Zwerg'   , 'M'         , 'Ferrek'   ),
                      ('Zwerg'   , 'M'         , 'Ulfgar'   ),
                      ('Zwerg'   , 'M'         , 'Kildal'   ),
                      ('Zwerg'   , 'M'         , 'Baelnar'  );

DELETE FROM `Vornamen` 
      WHERE `Volkname`   = 'Zwerg' 
        AND `Geschlecht` = 'W';

INSERT INTO `Vornamen`(`Volkname`, `Geschlecht`, `Name`     )
               VALUES ('Zwerg'   , 'W'         , 'Agna'     ),
                      ('Zwerg'   , 'W'         , 'Nurta'    ),
                      ('Zwerg'   , 'W'         , 'Valit'    ),
                      ('Zwerg'   , 'W'         , 'Unra'     ),
                      ('Zwerg'   , 'W'         , 'Kali'     ),
                      ('Zwerg'   , 'W'         , 'Lurka'    ),
                      ('Zwerg'   , 'W'         , 'Gilda'    ),
                      ('Zwerg'   , 'W'         , 'Belta'    ),
                      ('Zwerg'   , 'W'         , 'Norna'    ),
                      ('Zwerg'   , 'W'         , 'Adra'     ),
                      ('Zwerg'   , 'W'         , 'Dagla'    ),
                      ('Zwerg'   , 'W'         , 'Tora'     ),
                      ('Zwerg'   , 'W'         , 'Rona'     ),
                      ('Zwerg'   , 'W'         , 'Orkara'   ),
                      ('Zwerg'   , 'W'         , 'Morla'    ),
                      ('Zwerg'   , 'W'         , 'Risla'    ),
                      ('Zwerg'   , 'W'         , 'Cliana'   ),
                      ('Zwerg'   , 'W'         , 'Kotri'    ),
                      ('Zwerg'   , 'W'         , 'Kristryd' ),
                      ('Zwerg'   , 'W'         , 'Beyla'    );



DELETE FROM `Loot`;

INSERT INTO `Loot`(`Typ`        , `Seltenheit`, `Werte`               , `Name`                    )
           VALUES ('Armor'      , 'Uncommen'  , '+1AC'                , 'Adamantine Armor'        ),
                  ('Boots'      , 'Uncommen'  , '+1 Speed'            , 'Boots of Elvenkind'      ),
                  ('Accessories', 'Uncommen'  , 'Carry a lot'         , 'Bag of Holding'          ),
                  ('Armor'      , 'Uncommen'  , '+1 Stealth'          , 'Rouge Armor'             ),
                  ('Cloak'      , 'Uncommen'  , '+1AC'                , 'Cloak of Protection'     ),
                  ('Accessories', 'Uncommen'  , '+2AC'                , 'Ring of Protection'      ),
                  ('Sword'      , 'Rare'      , '1d6 against Dragons' , 'Flaming Sword'           ),
                  ('Shield'     , 'Rare'      , '+2AC'                , 'Shield of Defense'       ),
                  ('Sword'      , 'Rare'      , '+1d6 fire damage'    , 'Flaming Sword'           ),
                  ('Accessories', 'Rare'      , 'Invisibility'        , 'Elixier of Invisibility' ),
                  ('Accessories', 'Legendary' , 'you shall not ask!'  , 'Deck of many things'     ),
                  ('Armor'      , 'Legendary' , 'Strength = 19'       , 'Beld of Giant Strength'  );



DELETE FROM `Gegner`;

INSERT INTO `Gegner`(`Name`                      , `Typ`        ,  `Enviroment` , `CR` )
             VALUES ('Brown Bear'                , 'Beast'      , 'Forest'      , 1    ),
                    ('Dire Wolf'                 , 'Beast'      , 'Forest'      , 1    ),
                    ('Giant Eagle'               , 'Beast'      , 'Hill'        , 1    ),
                    ('Fire Snake'                , 'Elemental'  , 'Dungeon'     , 1    ),
                    ('Galcanic Soulblade'        , 'Elemental'  , 'Dungeon'     , 1    ),
                    ('Duargar Soulblade'         , 'Humanoid'   , 'Mountain'    , 1    ),
                    ('Knight'                    , 'Humanoid'   , 'City'        , 1    ),
                    ('Spy'                       , 'Humanoid'   , 'City'        , 1    ),
                    ('Ghast'                     , 'Undead'     , 'Swamp'       , 2    ),
                    ('Skeleton'                  , 'Undead'     , 'Dungeon'     , 2    ),
                    ('Orge'                      , 'Giant'      , 'Hill'        , 2    ),
                    ('Dragonpriest'              , 'Giant'      , 'Hill'        , 2    ),
                    ('Cave Bear'                 , 'Beast'      , 'Forest'      , 2    ),
                    ('Giant Elk'                 , 'Beast'      , 'Hill'        , 2    ),
                    ('Swarm of poisonous Snakes' , 'Beast'      , 'Forest'      , 2    ),
                    ('Bandit Captain'            , 'Humanoid'   , 'Forest'      , 2    ),
                    ('Berserker'                 , 'Humanoid'   , 'Hill'        , 2    ),
                    ('Berserker'                 , 'Humanoid'   , 'Hill'        , 2    ),
                    ('Cult Fanatic'              , 'Humanoid'   , 'Mountain'    , 2    ),
                    ('Archer'                    , 'Humanoid'   , 'Forest'      , 3    ),
                    ('Hobgoblin'                 , 'Humanoid'   , 'Dungeon'     , 3    ),
                    ('Werewolf'                  , 'Humanoid'   , 'Forest'      , 3    ),
                    ('Giant Scorpion'            , 'Beast'      , 'Hill'        , 3    ),
                    ('Twao headed Snake'         , 'Beast'      , 'Forest'      , 3    ),
                    ('Giant Direwolf'            , 'Beast'      , 'Hill'        , 3    ),
                    ('Earth Elemental'           , 'Elemental'  , 'Mountain'    , 3    ),
                    ('Fire Elemental'            , 'Elemental'  , 'Mountain'    , 3    ),
                    ('Water Elemental'           , 'Elemental'  , 'Hill'        , 3    ),
                    ('Air Elemental'             , 'Elemental'  , 'Hill'        , 3    );