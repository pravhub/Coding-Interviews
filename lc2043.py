class Bank:
    balances = []
    def __init__(self, balance: List[int]):
        self.balances = balance

    def transfer(self, account1: int, account2: int, money: int) -> bool:
        if(not self.validateIfAccountExists(account1) or not self.validateIfAccountExists(account2)):
            return False
        if(self.balances[account1-1] >= money):
            self.balances[account1-1] -= money
            self.balances[account2-1] += money
            return True
        else:
            return False
            

    def deposit(self, account: int, money: int) -> bool:
        if(not self.validateIfAccountExists(account)):
            return False
        self.balances[account-1] += money
        return True

    def withdraw(self, account: int, money: int) -> bool:
        if(not self.validateIfAccountExists(account)):
            return False
        if(self.balances[account-1] >= money):            
            self.balances[account-1] -= money
            return True
        else:
            return False
    
    def validateIfAccountExists(self, account:int) -> bool:
        if(len(self.balances) < account):
            return False
        else:
            return True


# Your Bank object will be instantiated and called as such:
# obj = Bank(balance)
# param_1 = obj.transfer(account1,account2,money)
# param_2 = obj.deposit(account,money)
# param_3 = obj.withdraw(account,money)
