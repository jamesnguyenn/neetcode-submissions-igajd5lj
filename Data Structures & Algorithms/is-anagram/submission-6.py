class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t): return False
        count_list = [0] * 26
        ascii_a = ord('a')
        for i in range(len(s)):
            count_list[ord(s[i]) - ascii_a] += 1
            count_list[ord(t[i]) - ascii_a] -= 1

        for count in count_list:
            if count != 0:
                return False
        return True