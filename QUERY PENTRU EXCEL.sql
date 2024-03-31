
SELECT  dbo.studenti.nume, dbo.studenti.prenume,dbo.discipline.denumire, dbo.catalog_note.nota, AVG(catalog_note.nota) OVER(PARTITION BY dbo.studenti.nume) AS medie, SUM(dbo.discipline.nr_credite * dbo.catalog_note.nota) OVER (PARTITION BY dbo.studenti.nume) AS punctaj, CASE WHEN MIN(dbo.catalog_note.nota) OVER (PARTITION BY dbo.catalog_note.nota) >= 5 THEN 'Integralist' ELSE 'Neintegralist' END AS informatie FROM studenti LEFT JOIN catalog_note ON catalog_note.nr_matricol = studenti.nr_matricol LEFT JOIN discipline ON discipline.cod_disciplina = catalog_note.cod_disciplina GROUP BY dbo.studenti.nume, dbo.studenti.prenume, dbo.discipline.denumire, dbo.catalog_note.nota, dbo.discipline.nr_credite ORDER BY studenti.nume




