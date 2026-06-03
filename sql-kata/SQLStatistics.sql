/*
SQL Statistics: MIN, MEDIAN, MAX - https://www.codewars.com/kata/58167fa1f544130dcf000317

For this challenge you need to create a simple SELECT statement. Your task is to calculate the MIN, MEDIAN and MAX scores of the students from the results table.

Table Relationships

 -- student--           -- result --
     -id-(P)               -id-
    -name-              -sstudent_id- (F)
                          -score-

Resultant table:

    min
    median
    max

*/



SELECT 
  min(score) as min, 
  PERCENTILE_CONT(0.5) WITHIN GROUP (ORDER BY score) as median,
  max(score) as max
  from result r
  join student s 
  on r.student_id = s.id