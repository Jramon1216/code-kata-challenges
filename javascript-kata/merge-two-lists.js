/**
 * Not from a kata just from a leetcode problem I worked on
 * 
 * 
 * @param {Array} - list1 
 * @param {Array} - list2 
 * @returns {Array} - a merged list between list1 and list2
 */


var mergeTwoLists = function (list1, list2) {
    if (!list1 && !list2) return []
    if (list1 && !list2) return list1
    if (!list1 && list2) return list2

    let count = 0
    let p1 = 0, p2 = 0;
    let result = []

    while (count !== (list1.length + list2.length)) {

        if (list1[p1] === list2[p2]) {
            result.push(list1[p1]);
            result.push(list2[p2]);
            p1++;
            p2++;
            count += 2
        } else if (list1[p1] > list2[p2]) {
            result.push(list2[p2]);
            p2++;
            count++;
        } else if (list1[p1] < list2[p2]) {
            result.push(list1[p1])
            p1++;
            count++;
        } else if (!list1[p1] && list2[p2]) {
            result.push(list2[p2]);
            p2++;
            count++;
        } else if (list1[p1] && !list2[p2]) {
            result.push(list1[p1]);
            p1++;
            count++;
        }
    }

    return result
};


console.log(mergeTwoLists([1, 2, 3], [1, 3, 4]))