class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        store = {}
        for item in strs:
            sort_string = "".join(sorted(item))
            if sort_string in store:
                store[sort_string].append(item)
            else:
                store[sort_string] = [item]

        return list(store.values())