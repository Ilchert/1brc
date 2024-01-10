# 1️⃣🐝🏎️ The One Billion Row Challenge

This is playground around [One billion rows challenge](https://github.com/gunnarmorling/1brc) with dotnet. Unfortunately I do not have 32GB memory to cache entire data to memory, so those will be focused on IO + CPU performance.
## Results

These are the results from running all entries into the challenge on 10 cores of a Surface Pro i5 1235U with 32 GB RAM Windows 10.

| # | Result (m:s.ms) | Implementation     | JDK | Submitter     | Notes     |
|---|-----------------|--------------------|-----|---------------|-----------|
| 1 | 00:03.044 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_thomaswue.java)| 21.0.1-graal | [Thomas Wuerthinger](https://github.com/thomaswue), [Quan Anh Mai](https://github.com/merykitty), [Alfonso² Peterssen](https://github.com/mukel) | GraalVM native binary |
| 2 | 00:03.258 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_merykitty.java)| 21.0.1-open | [Quan Anh Mai](https://github.com/merykitty) |  |
| 3 | 00:03.604 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_royvanrijn.java)| 21.0.1-graal | [Roy van Rijn](https://github.com/royvanrijn) |  |
|   | 00:04.996 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_ebarlas.java)| 21.0.1-graal | [Elliot Barlas](https://github.com/ebarlas) |  |
|   | 00:05.478 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_obourgain.java)| 21.0.1-open | [Olivier Bourgain](https://github.com/obourgain) |  |
|   | 00:05.979 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_spullara.java)| 21.0.1-graal | [Sam Pullara](https://github.com/spullara) |  |
|   | 00:06.166 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_isolgpus.java)| 21.0.1-open | [Jamie Stansfield](https://github.com/isolgpus) |  |
|   | 00:06.338 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_artsiomkorzun.java)| 21.0.1-graal | [artsiomkorzun](https://github.com/artsiomkorzun) |  |
|   | 00:06.715 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_algirdasrascius.java)| 21.0.1-open | [Algirdas Raščius](https://github.com/algirdasrascius) |  |
|   | 00:07.730 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_jotschi.java)| 21.0.1-open | [Johannes Schüth](https://github.com/jotschi) |  |
|   | 00:07.784 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_yavuztas.java)| 21.0.1-graal | [Yavuz Tas](https://github.com/yavuztas) |  |
|   | 00:08.167 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_ddimtirov.java)| 21.0.1-tem | [Dimitar Dimitrov](https://github.com/ddimtirov) |  |
|   | 00:08.214 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_deemkeen.java)| 21.0.1-open | [deemkeen](https://github.com/deemkeen) |  |
|   | 00:08.517 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_ags313.java)| 21.0.1-graal | [ags](https://github.com/ags313) |  |
|   | 00:09.020 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_yemreinci.java)| 21.0.1-open | [yemreinci](https://github.com/yemreinci) |  |
|   | 00:09.046 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_iziamos.java)| 21.0.1-open | [John Ziamos](https://github.com/iziamos) |  |
|   | 00:09.071 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_gabrielreid.java)| 21.0.1-open | [Gabriel Reid](https://github.com/gabrielreid) |  |
|   | 00:09.352 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_filiphr.java)| 21.0.1-graal | [Filip Hrisafov](https://github.com/filiphr) |  |
|   | 00:10.127 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_artpar.java)| 21.0.1-open | [Parth Mudgal](https://github.com/artpar) |  |
|   | 00:10.473 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_raipc.java)| 21.0.1-open | [Anton Rybochkin](https://github.com/raipc) |  |
|   | 00:10.642 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_asun.java)| 21.0.1-open | [Alan Sun](https://github.com/asun) |  |
|   | 00:11.119 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_lawrey.java)| 21.0.1-open | [lawrey](https://github.com/lawrey) |  |
|   | 00:11.167 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_palmr.java)| 21.0.1-open | [Nick Palmer](https://github.com/palmr) |  |
|   | 00:11.805 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_coolmineman.java)| 21.0.1-graal | [Cool_Mineman](https://github.com/coolmineman) |  |
|   | 00:11.934 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_arjenvaneerde.java)| 21.0.1-open | [arjenvaneerde](https://github.com/arjenvaneerde) |  |
|   | 00:11.987 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_flippingbits.java)| 21.0.1-graal | [Stefan Sprenger](https://github.com/flippingbits) |  |
|   | 00:12.253 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_zerninv.java)| 21.0.1-open | [zerninv](https://github.com/zerninv) |  |
|   | 00:12.557 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_imrafaelmerino.java)| 21.0.1-graal | [Rafael Merino García](https://github.com/imrafaelmerino) |  |
|   | 00:13.623 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_phd3.java)| 21.0.1-open | [Pratham](https://github.com/phd3) |  |
|   | 00:13.817 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_entangled90.java)| 21.0.1-open | [Carlo](https://github.com/entangled90) |  |
|   | 00:13.870 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_fatroom.java)| 21.0.1-open | [Roman Romanchuk](https://github.com/fatroom) |  |
|   | 00:14.628 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_richardstartin.java)| 21.0.1-open | [Richard Startin](https://github.com/richardstartin) |  |
|   | 00:14.772 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_kevinmcmurtrie.java)| 21.0.1-open | [Kevin McMurtrie](https://github.com/kevinmcmurtrie) |  |
|   | 00:14.867 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_berry120.java)| 21.0.1-open | [Michael Berry](https://github.com/berry120) |  |
|   | 00:15.662 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_semotpan.java)| 21.0.1-open | [Serghei Motpan](https://github.com/semotpan) |  |
|   | 00:17.490 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_kgeri.java)| 21.0.1-open | [Gergely Kiss](https://github.com/kgeri) |  |
|   | 00:18.251 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_seijikun.java)| 21.0.1-graal | [Markus Ebner](https://github.com/seijikun) |  |
|   | 00:18.448 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_moysesb.java)| 21.0.1-open | [Moysés Borges Furtado](https://github.com/moysesb) |  |
|   | 00:18.583 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_davecom.java)| 21.0.1-open | [David Kopec](https://github.com/davecom) |  |
|   | 00:19.357 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_truelive.java)| 21.0.1-graalce | [Roman Schweitzer](https://github.com/truelive) |  |
|   | 00:21.989 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_couragelee.java)| 21.0.1-open | [couragelee](https://github.com/couragelee) |  |
|   | 00:22.457 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_rby.java)| 21.0.1-open | [Ramzi Ben Yahya](https://github.com/rby) |  |
|   | 00:28.381 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_bjhara.java)| 21.0.1-open | [Hampus](https://github.com/bjhara) |  |
|   | 00:32.018 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_padreati.java)| 21.0.1-open | [Aurelian Tutuianu](https://github.com/padreati) |  |
|   | 00:34.388 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_twobiers.java)| 21.0.1-tem | [Tobi](https://github.com/twobiers) |  |
|   | 00:36.180 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_hchiorean.java)| 21.0.1-open | [Horia Chiorean](https://github.com/hchiorean) |  |
|   | 00:37.787 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_kuduwa-keshavram.java)| 21.0.1-open | [Keshavram Kuduwa](https://github.com/kuduwa-keshavram) |  |
|   | 00:38.340 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_AbstractKamen.java)| 21.0.1-open | [AbstractKamen](https://github.com/AbstractKamen) |  |
|   | 00:41.046 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_japplis.java)| 21.0.1-open | [Anthony Goubard](https://github.com/japplis) |  |
|   | 00:41.982 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_criccomini.java)| 21.0.1-open | [Chris Riccomini](https://github.com/criccomini) |  |
|   | 00:45.447 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_armandino.java)| 21.0.1-open | [Arman Sharif](https://github.com/armandino) |  |
|   | 00:58.811 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_Ujjwalbharti.java)| 21.0.1-open | [Ujjwal Bharti](https://github.com/Ujjwalbharti) |  |
|   | 01:05.094 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_mudit-saxena.java)| 21.0.1-open | [Mudit Saxena](https://github.com/mudit-saxena) |  |
|   | 01:06.790 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_khmarbaise.java)| 21.0.1-open | [Karl Heinz Marbaise](https://github.com/khmarbaise) |  |
|   | 01:06.944 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_santanu.java)| 21.0.1-open | [santanu](https://github.com/santanu) |  |
|   | 01:07.014 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_pedestrianlove.java)| 21.0.1-open | [pedestrianlove](https://github.com/pedestrianlove) |  |
|   | 01:07.978 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_jgrateron.java)| 21.0.1-open | [Jairo Graterón](https://github.com/jgrateron) |  |
|   | 01:08.908 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_itaske.java)| 21.0.1-open | [itaske](https://github.com/itaske) |  |
|   | 01:09.882 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_rprabhu.java)| 21.0.1-open | [Prabhu R](https://github.com/rprabhu) |  |
|   | 01:14.815 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_anandmattikopp.java)| 21.0.1-open | [twohardthings](https://github.com/anandmattikopp) |  |
|   | 01:33.594 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_gnmathur.java)| 21.0.1-open | [Gaurav Mathur](https://github.com/gnmathur) |  |
|   | 01:56.607 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_abfrmblr.java)| 21.0.1-open | [Abhilash](https://github.com/abfrmblr) |  |
|   | 03:43.521 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_yehwankim23.java)| 21.0.1-open | [김예환 Ye-Hwan Kim (Sam)](https://github.com/yehwankim23) |  |
|   | 03:59.760 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_fragmede.java)| 21.0.1-open | [Samson](https://github.com/fragmede) |  |
|   | ---       | | | | |
|   | 04:49.679 | [link](https://github.com/gunnarmorling/1brc/blob/main/src/main/java/dev/morling/onebrc/CalculateAverage_baseline.java) (Baseline) | 21.0.1-open | [Gunnar Morling](https://github.com/gunnarmorling) |  |
