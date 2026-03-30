class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {
        const array = Array(26).fill(0);
        for(let i = 0; i < s.length; i++)
        {
            const currentIndex = s[i].charCodeAt(0) - 'a'.charCodeAt(0);
            array[currentIndex]++;
        }
        for(let i = 0; i < t.length; i++)
        {
            const currentIndex = t[i].charCodeAt(0) - 'a'.charCodeAt(0);
            array[currentIndex]--;
        }
        return array.every(item=>item === 0);
    }
}
