/*
    Using Window Functions To Get Top N per Group - https://www.codewars.com/kata/582001237a3a630ce8000a41

    Description

    Given the schema presented below write a query, which uses a window function, that returns two most viewed posts for every category.

Order the result set by:

    category name alphabetically
    number of post views largest to lowest
    post id lowest to largest

Note:

    Some categories may have less than two or no posts at all.
    Two or more posts within the category can be tied by (have the same) the number of views. Use post id as a tie breaker - a post with a lower id gets a higher rank.

*/

WITH ranked_posts AS (
    SELECT 
        c.id AS category_id,
        c.category,
        p.id AS post_id,
        p.title,
        p.views,
        RANK() OVER (
            PARTITION BY c.id
            ORDER BY p.views DESC, p.id ASC
        ) AS rnk
    FROM categories AS c
    LEFT JOIN posts AS p ON p.category_id = c.id
)
SELECT
    category_id,
    category,
    post_id,
    title,
    views
FROM ranked_posts
WHERE rnk <= 2 OR post_id IS NULL
ORDER BY
    category ASC,
    views DESC,
    post_id ASC;