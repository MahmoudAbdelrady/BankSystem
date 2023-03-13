/* what was the branch with no customer
----------------------------------------
*/
SELECT BRANCH.BRANCHNUM
FROM BRANCH
WHERE BRANCH.BRANCHNUM NOT IN (SELECT CUSTOMER.BRANCHNUM
                               FROM CUSTOMER ) 
/*
-----------------------------------------
*/
/*
what was the branch with no employee
*/
SELECT BRANCH.BRANCHNUM
FROM BRANCH
WHERE BRANCH.BRANCHNUM NOT IN (SELECT EMPLOYEE.BRANCHNUM
                               FROM EMPLOYEE ) 
/*
-----------------------------------------
*/
/*
who was the customer didnot take any loan
*/
SELECT CUSTOMER.NAME
FROM CUSTOMER 
WHERE CUSTOMER.NAME NOT IN  (
                             SELECT CUSTOMER.NAME
                             FROM CUSTOMER,TAKE
                             WHERE CUSTOMER.SSN=TAKE.SSN
							 )
/*
--------------------------------------------------
*/
/*
f.retrieve all information
*/
SELECT name,ssn,branchnum,phone,customeradd,COUNT(EMP_SSN)AS NumberOfEmployee
FROM CUSTOMER
group by name,ssn,branchnum,phone,customeradd
/*
--------------------------------------------------
*/

/* Show list of loan with customer name and employee name 
-------------------------------------------------
*/
SELECT LOAN.LOANNUM,CUSTOMER.NAME,EMPLOYEE.EMP_NAME
FROM CUSTOMER,EMPLOYEE,TAKE,LOAN
WHERE CUSTOMER.EMP_SSN=EMPLOYEE.EMP_SSN
AND CUSTOMER.SSN=TAKE.SSN
AND TAKE.LOANNUM=LOAN.LOANNUM
/*----------------------------------------------*/
 /*
what were the customer who has max number of loan ? 
*/
SELECT CUSTOMER.NAME 
FROM  CUSTOMER,TAKE
WHERE CUSTOMER.SSN=TAKE.SSN   
GROUP BY CUSTOMER.NAME
HAVING COUNT (CUSTOMER.NAME)=
(SELECT MAX(MAXIMUM) 
FROM (

 SELECT  COUNT(CUSTOMER.NAME)AS MAXIMUM,CUSTOMER.NAME
 FROM CUSTOMER,TAKE 
 WHERE CUSTOMER.SSN=TAKE.SSN 
 GROUP BY CUSTOMER.NAME
 )AS NAME) 
 /*----------------------------------------------*/

  /*
what were the employee who has max number of loan added? 
*/
 SELECT EMPLOYEE.EMP_NAME
FROM  EMPLOYEE,PERFORM
WHERE EMPLOYEE.EMP_SSN=PERFORM.EMP_SSN   
GROUP BY EMPLOYEE.EMP_NAME
HAVING COUNT (EMPLOYEE.EMP_NAME)=
(SELECT MAX(MAXIMUM) 
FROM (

 SELECT  COUNT(EMPLOYEE.EMP_NAME)AS MAXIMUM,EMPLOYEE.EMP_NAME
 FROM EMPLOYEE,PERFORM 
 WHERE EMPLOYEE.EMP_SSN=PERFORM.EMP_SSN 
 GROUP BY EMPLOYEE.EMP_NAME
 )AS NAME)
  /*----------------------------------------------*/ 
  