"use strict";
/**
    PaginationHelper - https://www.codewars.com/kata/515bb423de843ea99400000a

    For this exercise you will be strengthening your page-fu mastery. You will complete the PaginationHelper class, which is a utility class helpful for querying paging information related to an array.

    The class is designed to take in an array of values and an integer indicating how many items will be allowed per each page. The types of values contained within the collection/array are not relevant.

    The following are some examples of how this class is used:

    helper = PaginationHelper(['a','b','c','d','e','f'], 4)
    helper.page_count() # should == 2
    helper.item_count() # should == 6
    helper.page_item_count(0) # should == 4
    helper.page_item_count(1) # last page - should == 2
    helper.page_item_count(2) # should == -1 since the page is invalid

    # page_index takes an item index and returns the page that it belongs on
    helper.page_index(5) # should == 1 (zero based index)
    helper.page_index(2) # should == 0
    helper.page_index(20) # should == -1
    helper.page_index(-10) # should == -1 because negative indexes are invalid
 */
var __spreadArray = (this && this.__spreadArray) || function (to, from, pack) {
    if (pack || arguments.length === 2) for (var i = 0, l = from.length, ar; i < l; i++) {
        if (ar || !(i in from)) {
            if (!ar) ar = Array.prototype.slice.call(from, 0, i);
            ar[i] = from[i];
        }
    }
    return to.concat(ar || Array.prototype.slice.call(from));
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.PaginationHelper = void 0;
var PaginationHelper = /** @class */ (function () {
    function PaginationHelper(collection, itemsPerPage) {
        // The constructor takes in an array of items and a integer indicating how many
        // items fit within a single page
        this.collection = collection;
        this.itemsPerPage = itemsPerPage;
        this.paginated = [];
    }
    PaginationHelper.prototype.itemCount = function () {
        // returns the number of items within the entire collection
        return this.collection.length;
    };
    PaginationHelper.prototype.pageCount = function () {
        if (!this.collection)
            return 0;
        var copy = __spreadArray([], this.collection, true);
        var result = [];
        var page = [];
        while (copy.length !== 0) {
            console.log(copy);
            page.push(copy[0]);
            copy.shift();
            if (page.length === this.itemsPerPage) {
                result.push(page);
                page = [];
            }
            else if (copy.length === 0) {
                result.push(page);
            }
        }
        this.paginated = result;
        return result.length;
    };
    PaginationHelper.prototype.pageItemCount = function (pageIndex) {
        // returns the number of items on the current page. page_index is zero based.
        // this method should return -1 for pageIndex values that are out of range
        if (pageIndex < 0 || !this.collection)
            return -1;
        return pageIndex >= 0 && pageIndex < this.paginated.length ? this.paginated[pageIndex].length : -1;
    };
    PaginationHelper.prototype.pageIndex = function (itemIndex) {
        // determines what page an item is on. Zero based indexes
        // this method should return -1 for itemIndex values that are out of range
        if (itemIndex < this.itemCount() && itemIndex >= 0) {
            return Math.floor(itemIndex / this.itemsPerPage);
        }
        else {
            return -1;
        }
        ;
    };
    return PaginationHelper;
}());
exports.PaginationHelper = PaginationHelper;
var collection = [1, 2, 3, 4];
var helper = new PaginationHelper(collection, 2);
console.log(helper.pageCount());
