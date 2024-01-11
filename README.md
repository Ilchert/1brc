# 1️⃣🐝🏎️ The One Billion Row Challenge

This is playground around [One billion rows challenge](https://github.com/gunnarmorling/1brc) with dotnet. Unfortunately I do not have 32GB memory to cache entire data to memory, so those will be focused on IO + CPU performance.
## Results

These are the results from running all entries into the challenge on 10 cores of a Surface Pro i5 1235U with 32 GB RAM Windows 10.

| # | Result (m:s.ms) | Implementation     | JDK | Submitter     | Notes     |
|---|-----------------|--------------------|-----|---------------|-----------|
|  | 00:20.261 | UTF8 Channels | dotnet8 |  |  |  |
|  | 02:45.024 | Simple | dotnet8 |  |  |  |
|  | 01:59.834 | U8StringSimple | dotnet8 |  |  |  |
|  | 0:13.095  | [gunnarmorling](https://github.com/gunnarmorling/1brc) | dotnet8 |  |  |  |
|  | 00:10.961 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_thomaswue.java)| 21.0.1-graal | [Thomas Wuerthinger](https://github.com/thomaswue), [Quan Anh Mai](https://github.com/merykitty), [Alfonso² Peterssen](https://github.com/mukel) | GraalVM native binary |
|  | 00:10.642 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_merykitty.java)| 21.0.1-open | [Quan Anh Mai](https://github.com/merykitty) |  |
|  |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_royvanrijn.java)| 21.0.1-graal | [Roy van Rijn](https://github.com/royvanrijn) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_ebarlas.java)| 21.0.1-graal | [Elliot Barlas](https://github.com/ebarlas) |  |
|   | | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_obourgain.java)| 21.0.1-open | [Olivier Bourgain](https://github.com/obourgain) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_spullara.java)| 21.0.1-graal | [Sam Pullara](https://github.com/spullara) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_isolgpus.java)| 21.0.1-open | [Jamie Stansfield](https://github.com/isolgpus) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_artsiomkorzun.java)| 21.0.1-graal | [artsiomkorzun](https://github.com/artsiomkorzun) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_algirdasrascius.java)| 21.0.1-open | [Algirdas Raščius](https://github.com/algirdasrascius) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_jotschi.java)| 21.0.1-open | [Johannes Schüth](https://github.com/jotschi) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_yavuztas.java)| 21.0.1-graal | [Yavuz Tas](https://github.com/yavuztas) |  |
|   | | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_ddimtirov.java)| 21.0.1-tem | [Dimitar Dimitrov](https://github.com/ddimtirov) |  |
|   | | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_deemkeen.java)| 21.0.1-open | [deemkeen](https://github.com/deemkeen) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_ags313.java)| 21.0.1-graal | [ags](https://github.com/ags313) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_yemreinci.java)| 21.0.1-open | [yemreinci](https://github.com/yemreinci) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_iziamos.java)| 21.0.1-open | [John Ziamos](https://github.com/iziamos) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_gabrielreid.java)| 21.0.1-open | [Gabriel Reid](https://github.com/gabrielreid) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_filiphr.java)| 21.0.1-graal | [Filip Hrisafov](https://github.com/filiphr) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_artpar.java)| 21.0.1-open | [Parth Mudgal](https://github.com/artpar) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_raipc.java)| 21.0.1-open | [Anton Rybochkin](https://github.com/raipc) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_asun.java)| 21.0.1-open | [Alan Sun](https://github.com/asun) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_lawrey.java)| 21.0.1-open | [lawrey](https://github.com/lawrey) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_palmr.java)| 21.0.1-open | [Nick Palmer](https://github.com/palmr) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_coolmineman.java)| 21.0.1-graal | [Cool_Mineman](https://github.com/coolmineman) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_arjenvaneerde.java)| 21.0.1-open | [arjenvaneerde](https://github.com/arjenvaneerde) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_flippingbits.java)| 21.0.1-graal | [Stefan Sprenger](https://github.com/flippingbits) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_zerninv.java)| 21.0.1-open | [zerninv](https://github.com/zerninv) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_imrafaelmerino.java)| 21.0.1-graal | [Rafael Merino García](https://github.com/imrafaelmerino) |  |
|   | 00:18.098 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_phd3.java)| 21.0.1-open | [Pratham](https://github.com/phd3) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_entangled90.java)| 21.0.1-open | [Carlo](https://github.com/entangled90) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_fatroom.java)| 21.0.1-open | [Roman Romanchuk](https://github.com/fatroom) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_richardstartin.java)| 21.0.1-open | [Richard Startin](https://github.com/richardstartin) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_kevinmcmurtrie.java)| 21.0.1-open | [Kevin McMurtrie](https://github.com/kevinmcmurtrie) |  |
|   | 00:18:406 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_berry120.java)| 21.0.1-open | [Michael Berry](https://github.com/berry120) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_semotpan.java)| 21.0.1-open | [Serghei Motpan](https://github.com/semotpan) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_kgeri.java)| 21.0.1-open | [Gergely Kiss](https://github.com/kgeri) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_seijikun.java)| 21.0.1-graal | [Markus Ebner](https://github.com/seijikun) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_moysesb.java)| 21.0.1-open | [Moysés Borges Furtado](https://github.com/moysesb) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_davecom.java)| 21.0.1-open | [David Kopec](https://github.com/davecom) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_truelive.java)| 21.0.1-graalce | [Roman Schweitzer](https://github.com/truelive) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_couragelee.java)| 21.0.1-open | [couragelee](https://github.com/couragelee) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_rby.java)| 21.0.1-open | [Ramzi Ben Yahya](https://github.com/rby) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_bjhara.java)| 21.0.1-open | [Hampus](https://github.com/bjhara) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_padreati.java)| 21.0.1-open | [Aurelian Tutuianu](https://github.com/padreati) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_twobiers.java)| 21.0.1-tem | [Tobi](https://github.com/twobiers) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_hchiorean.java)| 21.0.1-open | [Horia Chiorean](https://github.com/hchiorean) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_kuduwa-keshavram.java)| 21.0.1-open | [Keshavram Kuduwa](https://github.com/kuduwa-keshavram) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_AbstractKamen.java)| 21.0.1-open | [AbstractKamen](https://github.com/AbstractKamen) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_japplis.java)| 21.0.1-open | [Anthony Goubard](https://github.com/japplis) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_criccomini.java)| 21.0.1-open | [Chris Riccomini](https://github.com/criccomini) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_armandino.java)| 21.0.1-open | [Arman Sharif](https://github.com/armandino) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_Ujjwalbharti.java)| 21.0.1-open | [Ujjwal Bharti](https://github.com/Ujjwalbharti) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_mudit-saxena.java)| 21.0.1-open | [Mudit Saxena](https://github.com/mudit-saxena) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_khmarbaise.java)| 21.0.1-open | [Karl Heinz Marbaise](https://github.com/khmarbaise) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_santanu.java)| 21.0.1-open | [santanu](https://github.com/santanu) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_pedestrianlove.java)| 21.0.1-open | [pedestrianlove](https://github.com/pedestrianlove) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_jgrateron.java)| 21.0.1-open | [Jairo Graterón](https://github.com/jgrateron) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_itaske.java)| 21.0.1-open | [itaske](https://github.com/itaske) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_rprabhu.java)| 21.0.1-open | [Prabhu R](https://github.com/rprabhu) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_anandmattikopp.java)| 21.0.1-open | [twohardthings](https://github.com/anandmattikopp) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_gnmathur.java)| 21.0.1-open | [Gaurav Mathur](https://github.com/gnmathur) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_abfrmblr.java)| 21.0.1-open | [Abhilash](https://github.com/abfrmblr) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_yehwankim23.java)| 21.0.1-open | [김예환 Ye-Hwan Kim (Sam)](https://github.com/yehwankim23) |  |
|   |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_fragmede.java)| 21.0.1-open | [Samson](https://github.com/fragmede) |  |
|   | ---       | | | | |
|  2:42.742 |  | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_baseline.java) (Baseline) | 21.0.1-open | [Gunnar Morling](https://github.com/gunnarmorling) |  |
