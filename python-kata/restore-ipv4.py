import re 

"""
Restore IPv4Address class - https://www.codewars.com/kata/63a0f3f49547e9001e7ad1ca

IPv4Address class has been corrupted by a malevolent team lead. As a most experienced person in the team, you're tasked to restore the missing code. On the bright side, all the unit tests have been left intact. However, you have a gut feeling that you'll need to do something extraordinary…
"""


class IPv4Address: 
    def __init__(self, parts: list[int] | str):  # Type hint to ensure only specified types can be passed in
        """
        Creates an object representing an IPv4 address

        :param parts: a list of 4 integers
        """
        self._parts = self._parts_validator(parts)
    
    def __str__(self) -> str:
        return self._parts


    def __eq__(self, other): 
        if not isinstance(other, IPv4Address):
            return False
        return self._parts == other._parts
    
    # TODO: Implement class methods for operators
    # * They need to return a boolean
    # * They need to raise a Type error if 'other' is not the correct type
    # * Look into @total_ordering class decorator
    # * Compare octet to octet depending on the comparison method

    def __ne__(self, other: object) -> bool: # Not Equals
        pass
        
    def __le__(self, other: object) -> bool: # Less than or equal to
        pass

    def __lt__(self, other: object) -> bool: # less than
        pass
    
    def __ge__(self, other: object) -> bool: # Greater than or equal to
        pass

    def __gt__(self, other: object) -> bool: # Greater than
        pass



    def __hash__(self) -> int:
        return hash((self._parts,))

    # Property validation using @property decorator
    @property
    def parts(self):
        return self._parts
    
    # Rest of input validation requirements
    def _parts_validator(self, ipv4) -> str:
        if  ipv4[0] == 0: # First part of address can't be 0
            raise ValueError('Should not create IPv4Address where first part is 0')
        
        if type(ipv4) == list:
            if len(ipv4) < 4: 
                raise ValueError('Should not create IPv4Address with less than 4 parts')
            if len(ipv4) > 4:
                raise ValueError('Should not create IPv4Address with more than 4 parts')
            if any(isinstance(i, str) for i in ipv4):
                raise ValueError('Should not create IPv4Address with non-integer parts')
            if any(num < 0 or num > 255 for num in ipv4):
                raise ValueError('address parts should be between 0 and 255')
            
            return  ".".join(list(map(str, ipv4)))


        elif type(ipv4) == str: # if a string is passed in, ensure it's a proper ipv4 address
            match = re.fullmatch("^(?:(?:25[0-5]|2[0-4]\\d|1?\\d{1,2})(?:\\.(?!$)|$)){4}$", ipv4) is not None
            if not match:
                raise ValueError('Invalid IPV4 address')
 
            return  ipv4
    
        raise TypeError("Parts must be list or string")


    @classmethod
    def from_string(cls, string):
         return cls(string)



print(str(IPv4Address([1, 2, 3, 4])))
# print(IPv4Address.from_string('1.2.3.4'))
# print(f"Hashes are equal? " , hash(IPv4Address([1, 2, 3, 4])) == hash(IPv4Address([4, 2, 3, 2])))
# print(f"Addresses are equal? ", id(IPv4Address([1, 2, 3, 4])) == id(IPv4Address([4, 2, 3, 2])))
